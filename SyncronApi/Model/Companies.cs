using System.Runtime.Serialization;

namespace SyncronApi.Model
{
    public class Companies : CompanyFrom
    {
        public Companies(Guid id, string name/*, Guid address*/): base(id, name/*, address*/)
        {
            this.Id = id;
            this.Name = name;
         //   this.Address = address;

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
      //  [DataMember]
   //     public Guid Address { get; set; }
        //public ICollection<Jobs> Jobs { get; set; }
        //public ICollection<Contacts> Contacts { get; set; }


    }
}
