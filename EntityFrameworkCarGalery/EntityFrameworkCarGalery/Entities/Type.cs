using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCarGalery.Entities
{
    public class Type
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public virtual ICollection<Vehicle> Vehicles { get; set; }

        public Type()
        {
            Vehicles = new List<Vehicle>();
        }

        public Type(int id, string name)
        {
            Vehicles = new List<Vehicle>();

            Id = id;

            Name = name;
        }
    }


}
