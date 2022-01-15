namespace SyncronApi.Model
{
    public class OwnCompany : CompanyFrom
    {
        public OwnCompany(Guid id, string name/*, Guid address*/, Workers workers) : base(id, name/*, address*/)
        {
            this.Workers = workers;
        }

        public Workers Workers { get; set; }

    }
}
