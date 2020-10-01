using Microsoft.EntityFrameworkCore;
using MutlubievWebAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutlubievWebAPI.DAL.Context
{
    public class MutlubievWebApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=MutlubievDB; integrated security=true; ");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
    }
}
