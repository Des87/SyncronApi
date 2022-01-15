using Microsoft.EntityFrameworkCore;
using SyncronApi.Model;
using System.Data.SqlClient;

namespace SyncronApi
{
    public class Localdb: DbContext
    {
        public Localdb() : base()
        {
        }
        public DbSet<User> User { get; set; }
        //public DbSet<Address> Address { get; set; }
        //public DbSet<Person> Person { get; set; }
        //public DbSet<Companies> Companies { get; set; }
        //public DbSet<CompanyFrom> CompanyFrom { get; set; }
        //public DbSet<Contacts> Contact { get; set; }
        //public DbSet<Jobs> Jobs { get; set; }
        //public DbSet<OwnCompany> OwnCompany { get; set; }
        //public DbSet<Pictures> Pictures { get; set; }
        //public DbSet<Workers> Workers { get; set; }
        //public DbSet<WorkPages> WorkPages { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        //}
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //    modelBuilder.HasDefaultSchema("Admin");

        //    modelBuilder.Entity<User>().ToTable("User");

        //    modelBuilder.Entity<User>()
        //        .Property(p => p.Id)
        //        .IsRequired();

        //    modelBuilder.Entity<User>()
        //        .Property(p => p.Name)
        //        .HasMaxLength(50)
        //        .IsRequired();


        //}
}
