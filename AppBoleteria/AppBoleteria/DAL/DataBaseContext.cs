using AppBoleteria.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.Metrics;

namespace AppBoleteria.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        public DbSet<Ticket> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Ticket>().Property(p => p.IsUse).HasDefaultValue(false);
            modelBuilder.Entity<Ticket>().Property(p => p.UseDate).HasDefaultValue(null);
            modelBuilder.Entity<Ticket>().Property(p => p.EntranceGate).HasDefaultValue(null);
           
        }
    }
}
