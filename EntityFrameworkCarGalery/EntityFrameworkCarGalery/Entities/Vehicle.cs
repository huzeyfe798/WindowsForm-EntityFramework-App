using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCarGalery.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public string FuelType { get; set; }
        public string Year { get; set; }
        public string Km { get; set; }

        public virtual Type Type { get; set; }
        public virtual Model Model { get; set; }
        public virtual Brand Brand { get; set; }

        public Vehicle()
        {
            
        }

        public Vehicle(int id,string name,int typeId,int brandId, int modelId,string fuelType,string year, string km)
        {
            Id = id;
            Name = name;
            TypeId = typeId;
            BrandId = brandId;
            ModelId = modelId;
            FuelType = fuelType;
            Year = year;
            Km = km;
        }

        public Vehicle(string name, int typeId, int brandId, int modelId, string fuelType, string year, string km)
        {
            Name = name;
            TypeId = typeId;
            BrandId = brandId;
            ModelId = modelId;
            FuelType = fuelType;
            Year = year;
            Km = km;
        }

    }
}
