using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCarGalery.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Model> Models { get; set; }

        public Brand()
        {
            Vehicles = new List<Vehicle>();

            Models = new List<Model>();
        }

        public Brand(int id, string name)
        {
            Vehicles = new List<Vehicle>();

            Models = new List<Model>();

            Id = id;

            Name = name;
        }
    }
}
