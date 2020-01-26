using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCarGalery.Context;
using EntityFrameworkCarGalery.Entities;
using Type = EntityFrameworkCarGalery.Entities.Type;

namespace EntityFrameworkCarGalery.Config
{
    class MigrationConfigs
    {
        public static void Seed(GaleryContext context)
        {
            List<Type> types = new List<Type>()
            {
                new Type(1,"Otomobil"),
                new Type(2,"Arazi"),
                new Type(3,"Motosiklet")
            };

            List<Brand> brands = new List<Brand>()
            {
                new Brand(1,"Audi"),
                new Brand(2,"BMW"),
                new Brand(3, "Volkswagen"),
                new Brand(4, "Toyota"),
                new Brand(5, "Volvo")

            };
            List<Model> models = new List<Model>()
            {
                //motorsiklet
                new Model(1,"C1",2),
                new Model(2,"F650",2),
                //arabalar

                //bmw
                new Model(3,"320d",2),
                new Model(4,"X6",2),
                //Audi
                new Model(5,"A3",1),
                new Model(6,"Q7",1),
                //Volkswagen
                new Model(7,"Passat",3),
                new Model(8,"Amarok",3),
                //Toyota
                new Model(9,"Auris",4),
                new Model(10,"Land Cruiser",4),
                //Volvo
                new Model(11,"S90",5),
                new Model(12,"XC60",5),
            };

            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Vehicle(1,"BMW C1 Motorsiklet",3 ,2,1,"Benzin","2019","10000"),
                new Vehicle(2,"BMW C1- Motorsiklet",3 ,2,1,"Benzin","2015","50000"),
                new Vehicle(3,"BMW F650 Motorsiklet",3 ,2,2,"Benzin","2019","0"),
                new Vehicle(4,"BMW F650- Motorsiklet",3 ,2,2,"Benzin","2015","75000"),
                new Vehicle(5,"BMW 320D Araba",1 ,2,3,"Dizel","2020","0"),
                new Vehicle(6,"BMW 320D- Araba",1 ,2,3,"Dizel","2012","65000"),
                new Vehicle(7,"BMW X6 ARAZİ ARACI",2 ,2,4,"Benzin","2018","20000"),
                new Vehicle(8,"BMW X6 ARAZİ ARACI",2 ,2,4,"Dizel","2013","55000"),
                new Vehicle(9,"AUDİ A3 Araba",1 ,1,5,"Dizel","2020","0"),
                new Vehicle(10,"AUDİ A3- Araba",1 ,1,5,"Dizel","2012","65000"),
                new Vehicle(11,"AUDİ Q7 ARAZİ ARACI",2 ,1,6,"Benzin","2018","20000"),
                new Vehicle(12,"AUDİ Q7- ARAZİ ARACI",2 ,1,6,"Dizel","2013","55000"),

            };

            foreach (var type in types)
            {
                context.Types.AddOrUpdate(v => v.Id, type);
            }

            foreach (var model in models)
            {
                context.Models.AddOrUpdate(v => v.Id, model);
            }

            foreach (var brand in brands)
            {
                context.Brands.AddOrUpdate(v => v.Id, brand);
            }

            foreach (var vehicle in vehicles)
            {
                context.Vehicles.AddOrUpdate(v => v.Id, vehicle);
            }
            


        }
    }
}
