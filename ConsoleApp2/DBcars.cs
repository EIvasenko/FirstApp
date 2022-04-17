using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Bibliography;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    class Cars
    {[Key]
        public string Name { get; set; }
        public int Year { get; set; }
        public int Cost { get; set; }
        public int Mileage { get; set; }
    }
    [Keyless]
    class Parts
    {
        public string Brakes { get; set; }
        public string Lamps { get; set; }
        public string Filters { get; set; }
    }
    class Firm
    {
        public string Firm1 { get; set; }
        [Key]
        public int ID { get; set; }

    }
    class CarsDbContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Parts> Parts { get; set; }
        public DbSet<Firm> Firm { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SqlExpress; Database = Homework; Trusted_Connection = True;");
        }
    }
    class Program
    {
        CarsDbContext dbContext = new CarsDbContext();
        Firm newFirm = new Firm();
        public void FillDatabase()
        {
            newFirm.Firm1 = "Roga";
            dbContext.Firm.Add(newFirm);
            dbContext.SaveChanges();
        }
            
        
       



        
        

    }
}

