namespace SyncronApi.Model
{
    public class Person
    {
        public Person(Guid id, string name, Address address, string email, string mobileNumber)
        {

            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.MobileNumber = mobileNumber;

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }

      
    }
}
