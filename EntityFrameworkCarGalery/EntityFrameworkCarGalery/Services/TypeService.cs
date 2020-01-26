using EntityFrameworkCarGalery.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = EntityFrameworkCarGalery.Entities.Type;

namespace EntityFrameworkCarGalery.Services
{
    class TypeService
    {
        public List<Type> GetList()
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    return db.Types.ToList();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Typelar DataBaseden Getirilemedi.");
                throw exc;
            }
        }

        public void AddList(Type type)
        {
            try
            {
                using (GaleryContext db = new GaleryContext())
                {
                    List<Type> types = db.Types.Where(t => t.Name == type.Name).ToList();

                    if(types.Count != 0)
                    {
                        MessageBox.Show("Kayıt daha önce kaydedilmiş");
                    }
                    else
                    {
                        db.Types.Add(type);
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
