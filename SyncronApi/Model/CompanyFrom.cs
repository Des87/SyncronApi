namespace SyncronApi.Model
{
    public class CompanyFrom
    {
        public CompanyFrom(Guid id, string name/*, Guid address*/)
        {

            this.Id = id;
            this.Name = name;
        //    this.Address = address;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
 //       public Guid Address { get; set; }
 
    }
}
