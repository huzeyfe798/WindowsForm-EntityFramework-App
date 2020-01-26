using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkCarGalery.Context;
using EntityFrameworkCarGalery.Entities;

namespace EntityFrameworkCarGalery.Services
{
    class VehicleService
    {
        public List<Vehicle> GetList()
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Vehicles.ToList();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Araçlar DataBaseden Getirilemedi.");
                throw exc;
            }
        }

        public List<Vehicle> SearchList(string text)
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Vehicles.Where(t => t.Name.Contains(text)).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Araç aramasında hata meydana geldi.");
                throw;
            }
        }

        public List<Vehicle> GetFilterId(int typeIndex, int modelIndex, int brandIndex)
        {
            List<Vehicle> list1 = null;
            if (typeIndex == 0 || modelIndex == 0 || brandIndex == 0)
            {
                MessageBox.Show("Verilerin Hepsini Giriniz");

                return null;
            }
            else
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Vehicles.Where(v=> v.TypeId == typeIndex).Where(k=>k.ModelId == modelIndex).Where(x=>x.BrandId == brandIndex).ToList();
                }
                
            }
        }

        public void AddList(Vehicle vehicle)
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    List<Vehicle> types = db.Vehicles.Where(z => z.Name == vehicle.Name).ToList();

                    if (types.Count != 0)
                    {
                        MessageBox.Show("Kayıt daha önce kaydedilmiş");
                    }
                    else
                    {
                        db.Vehicles.Add(vehicle);
                        db.SaveChanges();
                        MessageBox.Show("Kayıt eklendi");
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Vehicle GetById(int id)
        {
            using (GaleryContext db = new GaleryContext())
            {
                return db.Vehicles.Find(id);
            }
        }

        public void Update(Vehicle vehicle)
        {
            using (GaleryContext db = new GaleryContext())
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal void Delete(int value)
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    var vehicle1 = GetById(value);
                    vehicle1 = db.Vehicles.FirstOrDefault(e => e.Id == value);
                    db.Vehicles.Remove(vehicle1);
                    db.SaveChanges();

                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
