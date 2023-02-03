using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NeverCore.Models;

namespace NeverCore.Data
{
    public class NeverCoreContext : DbContext
    {
        public NeverCoreContext(DbContextOptions<NeverCoreContext> options)
            : base(options)
        {
        }

        public DbSet<NeverCore.Models.user>? user { get; set; } = default!;
        public DbSet<NeverCore.Models.khata>? khata { get; set; }
        public DbSet<NeverCore.Models.v_user>? v_user { get; set; }
        public DbSet<NeverCore.Models.v_never>? v_never { get; set; }
        public DbSet<NeverCore.Models.count_jensiat>? count_jensiat { get; set; }
        public DbSet<NeverCore.Models.count_khata>? count_khata { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<v_user>()
            .ToView(nameof(v_user))
            .HasNoKey();

            //modelBuilder.Entity<v_never>()
            //.ToView(nameof(v_never))
            //.HasNoKey();

            modelBuilder.Entity<count_jensiat>()
            .ToView(nameof(count_jensiat))
            .HasNoKey();      
            
            modelBuilder.Entity<count_khata>()
            .ToView(nameof(count_khata))
            .HasNoKey();




        }




        public DbSet<NeverCore.Models.never>? never { get; set; }




        public DbSet<NeverCore.Models.jensiat>? jensiat { get; set; }




        public DbSet<NeverCore.Models.mobile>? mobile { get; set; }

        public DbSet<NeverCore.Models.sentsms>? sentsms { get; set; }

        public DbSet<NeverCore.Models.bakhsh>? bakhsh { get; set; }






    }
}
