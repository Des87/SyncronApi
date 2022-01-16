using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncronApi.Model
{
    public class Workers
    {
        //public Workers(Guid id, string name, Guid addressId, string email, string mobileNumber)
        //{
        //    Id = id;
        //    Name = name;
        //    AddressId = addressId;
        //    Email = email;
        //    MobileNumber = mobileNumber;

        //}
        public Guid Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }

    }
}
