using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SyncronApi.Model
{
    public class Companies
    {
        //public Companies(Guid id, string name, Guid addressId)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.AddressId = addressId;

        //}
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        public ICollection<Contacts> Contacts { get; set; }


    }
}
