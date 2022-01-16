using System.ComponentModel.DataAnnotations.Schema;

namespace SyncronApi.Model
{
    public class Contacts
    {
        //public Contacts(Guid id, string name, Address address, string email, string mobileNumber, Companies companies)
        //{
     
        //}
        public Guid Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
    }
}
