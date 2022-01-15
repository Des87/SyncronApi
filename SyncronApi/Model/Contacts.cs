namespace SyncronApi.Model
{
    public class Contacts : Person
    {
        public Contacts(Guid id, string name, Address address, string email, string mobileNumber, Companies companies) : base(id, name, address, email, mobileNumber)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.MobileNumber = mobileNumber;
            this.Companies = companies;
        }
        public Companies Companies { get; set; }
    }
}
