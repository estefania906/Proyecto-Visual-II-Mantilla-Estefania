using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Modelo;

namespace ModeloDB
{
    public class ModeloDB : DbContext 

    {
        public DbSet<City> cliente { get; set; }
        public DbSet<Country> country { get; set; }
        public DbSet<Address> address { get; set; }


        override protected void OnConfiguring(DbContextOptionsBuilder options)

        {


            options.UseSqlServer("Server = ACER\\MSSQLSERVER2; initial catalog= ExamenVisual ; trusted_connection=true;");

        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<City>()
                .HasOne(city => city.Country)
                .WithMany(country => country.City)
                .HasForeignKey(city => city.country_id);

            modelBuilder.Entity<Address>()
               .HasOne(address => address.City)
               .WithMany(city => city.Address)
               .HasForeignKey(address => address.city_id);
        }
    }

}

