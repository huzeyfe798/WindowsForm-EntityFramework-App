using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCarGalery.Entities;
using Type = EntityFrameworkCarGalery.Entities.Type;

namespace EntityFrameworkCarGalery.Context
{
    class GaleryContext:DbContext
    {
        public GaleryContext(): base("CarGaleryContext")
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Model> Models { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<Type>().ToTable("Types");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<Model>().ToTable("Models");

            modelBuilder.Entity<Brand>().HasKey(b => b.Id)
                .HasMany(b =>b.Models)
                .WithRequired(m => m.Brand)
                .HasForeignKey(m=>m.BrandId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Brand>().HasKey(b=>b.Id)
                .HasMany(v=>v.Vehicles)
                .WithRequired(v =>v.Brand)
                .HasForeignKey(v=>v.BrandId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Model>().HasKey(m=>m.Id)
                .HasMany(m=>m.Vehicles)
                .WithRequired(v=>v.Model)
                .HasForeignKey(v=>v.ModelId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Type>().HasKey(t=>t.Id)
                .HasMany(t=>t.Vehicles)
                .WithRequired(v=>v.Type)
                .HasForeignKey(v=>v.TypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
