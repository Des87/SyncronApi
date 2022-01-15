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
       // public DbSet<User>? User { get; set; }
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

    }
}
