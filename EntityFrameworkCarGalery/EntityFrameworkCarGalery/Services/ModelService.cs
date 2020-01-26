using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkCarGalery.Context;
using EntityFrameworkCarGalery.Entities;

namespace EntityFrameworkCarGalery.Services
{
    class ModelService
    {
        public List<Model> GetList()
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Models.ToList();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Modeller DataBaseden Getirilemedi.");
                throw exc;
            }
        }

        public void AddList(Model model)
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    List<Model> types = db.Models.Where(m => m.Name == model.Name).ToList();

                    if (types.Count != 0)
                    {
                        MessageBox.Show("Model Kayıt daha önce kaydedilmiş");
                    }
                    else
                    {
                        db.Models.Add(model);
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
