using System.ComponentModel.DataAnnotations;

namespace SyncronApi.Model
{
    public class Address
    {
       
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string Regio { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostNumber { get; set; }
        public List<Workers> Workers { get; set; }
        public List<Contacts> Contacts { get; set; }
        public List<Companies> Companies { get; set; }

        //public Address(Guid id, string country, string regio, string city, string street, string houseNumber, string postNumber)
        //{

        //    this.Id = id;
        //    this.Country = country;
        //    this.Regio = regio; 
        //    this.City = city;
        //    this.Street = street;    
        //    this.HouseNumber = houseNumber;
        //    this.PostNumber = postNumber;

        //}
    }
}
