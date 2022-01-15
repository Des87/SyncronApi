using System.Drawing;

namespace SyncronApi.Model
{
    public class Pictures
    {
        public Pictures(Guid id, string description, byte photo, WorkPages workPage)
        {
            this.Id = id;
            this.Description = description;
            this.Photo = photo;
            this.WorkPage = workPage;
               
        }
        public Guid Id { get; set; }
        public string Description { get; set; }
        public byte Photo { get; set; }
        public WorkPages WorkPage { get; set; }

       
    }
}
