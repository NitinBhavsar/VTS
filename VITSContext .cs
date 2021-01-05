using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VTSAPI.Models;

namespace VTSAPI.DBContexts
{
    
        public class VITSContext : DbContext
        {
            public VITSContext(DbContextOptions<VITSContext> options) : base(options)
            {
            }
            public DbSet<User> Users { get; set; }
            public DbSet<Vehicle> Vehicles { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
               
            }

        }
    
}
