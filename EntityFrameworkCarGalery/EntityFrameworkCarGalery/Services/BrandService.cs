using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkCarGalery.Context;
using EntityFrameworkCarGalery.Entities;

namespace EntityFrameworkCarGalery.Services
{
    class BrandService
    {
        public List<Brand> GetList()
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Brands.ToList();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Brands DataBaseden Getirilemedi.");
                throw exc;
            }
        }

        public void AddList(Brand brand)
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    List<Brand> types = db.Brands.Where(b => b.Name == brand.Name).ToList();

                    if (types.Count != 0)
                    {
                        MessageBox.Show("Kayıt daha önce kaydedilmiş");
                    }
                    else
                    {
                        db.Brands.Add(brand);
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
    }
}
