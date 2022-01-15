namespace SyncronApi.Model
{
    public class WorkPages
    {
        public WorkPages(Guid id, string description)
        {
            this.Id = id;
            this.Description = description;
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        //public ICollection<Pictures> Pictures { get; set; }
        //public ICollection<Jobs> Jobs { get; set; }
    }
}
