using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    class Cars
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Cost { get; set; }
        public int mileage { get; set; }
    }
    class Park
    {
        public string Rent { get; set; }
        public string Sale { get; set; }
        public string Repair { get; set; }
    }
    class Firm
    {
        public string Firm1 { get; set; }
        public string Firm2 { get; set; }
        public string Firm3 { get; set; }
    }
    class CarsDbContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Park> Park { get; set; }
        public DbSet<Firm> Firm { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SqlExpress; Database = Homework; Trusted_Connection = True;");
        }
    }
    class Program
    {
        CarsDbContext dbContext = new CarsDbContext();
    }


