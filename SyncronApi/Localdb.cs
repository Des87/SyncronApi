using Microsoft.EntityFrameworkCore;
using SyncronApi.Model;
using System.Data.SqlClient;

namespace SyncronApi
{
    public class Localdb: DbContext
    {
        public Localdb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Contacts> Contact { get; set; }
        //public DbSet<OwnCompany> OwnCompany { get; set; }
        public DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasIndex(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Country).HasColumnName("Country").HasMaxLength(50);

                entity.Property(e => e.Regio).HasColumnName("Regio").HasMaxLength(50);
                entity.Property(e => e.City).HasColumnName("City").HasMaxLength(50);
                entity.Property(e => e.Street).HasColumnName("Street").HasMaxLength(50);
                entity.Property(e => e.HouseNumber).HasColumnName("HouseNumber").HasMaxLength(50);
                entity.Property(e => e.PostNumber).HasColumnName("PostNumber").HasMaxLength(50);

                //entity.HasOne(d => d.Order)
                //    .WithMany(p => p.OrderDetails)
                //    .HasForeignKey(d => d.OrderId);
            });
        }
    }
}
