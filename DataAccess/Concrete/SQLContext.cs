using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class SQLContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=test;Trusted_Connection=true");
        }


        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<SepetUrun> SepetUrun { get; set; }

    }
}
