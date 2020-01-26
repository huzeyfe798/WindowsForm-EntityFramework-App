using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCarGalery.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual Brand Brand { get; set; }

        public Model()
        {
            Vehicles = new List<Vehicle>();

        }

        public Model(string name,int brandid)
        {
            Name = name;
            BrandId = brandid;
        }
        public Model(int id, string name, int brandId)
        {
            Vehicles = new List<Vehicle>();

            Id = id;
            Name = name;
            BrandId = brandId;
        }

        
    }
}
