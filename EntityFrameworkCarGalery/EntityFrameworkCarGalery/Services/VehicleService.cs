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
            if (typeIndex == 0 )
            {
                MessageBox.Show("Filtreleme için seçim yapılmadı.");

                return null;
            }
            else if (brandIndex == 0)
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Vehicles.Where(v=>v.TypeId == typeIndex).Where(v=>v.TypeId == typeIndex).ToList();
                }
            }
            else if (modelIndex == 0)
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Vehicles.Where(v=>v.TypeId == typeIndex).Where(v=>v.BrandId == brandIndex).ToList();
                }
            }
            else
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Vehicles.Where(v => v.TypeId == typeIndex).Where(k => k.ModelId == modelIndex).Where(x => x.BrandId == brandIndex).ToList();
                }

            }
        }
        public List<Brand> GetBrandFromType(int index )
        {

            List<Vehicle> list1 = null;

            List<Brand> brand1 = new List<Brand>();
            
            using (GaleryContext db = new GaleryContext())
            {
                list1 = db.Vehicles.Where(v => v.TypeId == index).ToList();

                foreach (var br in list1)
                {
                    brand1.Add(br.Brand);
                }

                return brand1;
            }

        }

        public List<Model> GetModelFromType(int index , int index1)
        {

            List<Vehicle> list1 = null;

            List<Model> brand1 = new List<Model>();
            
            using (GaleryContext db = new GaleryContext())
            {
                list1 = db.Vehicles.Where(v => v.BrandId == index).Where(v=>v.TypeId == index1).ToList();

                foreach (var br in list1)
                {
                    brand1.Add(br.Model);
                }

                return brand1;
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
