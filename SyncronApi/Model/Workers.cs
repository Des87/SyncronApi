namespace SyncronApi.Model
{
    public class Workers : Person
    {
        public Workers(Guid id, string name, Address address, string email, string mobileNumber) : base(id, name, address, email, mobileNumber)
        {
        }

        //public ICollection<Jobs> Jobs { get; set; }
        //public ICollection<OwnCompany> OwnCompany { get; set; }
    }
}
