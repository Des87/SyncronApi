namespace SyncronApi.Model
{
    public class Jobs
    {
        public Jobs(Guid id, Address deliveryAddress, Companies customer, WorkPages workPage, bool doneJob, Workers userCreated, DateTime objectCreated, DateTime jobStart, DateTime finishJob)
        {
            this.Id = id;
            this.DeliveryAddress = deliveryAddress;
            this.Customer = customer;
            this.WorkPage = workPage;
            this.DoneJob = doneJob;
            this.UserCreated = userCreated;
            this.ObjectCreated = objectCreated;
            this.JobStart = jobStart;
            this.FinishJob = finishJob;

        }
        public Guid Id { get; set; }
        public Address DeliveryAddress { get; set; }
        public Companies Customer { get; set; }
        public WorkPages WorkPage { get; set; }
        public bool DoneJob { get; set; }
        public Workers UserCreated { get; set; }
        public DateTime ObjectCreated { get; set; }
        public DateTime JobStart { get; set; }
        public DateTime FinishJob { get; set; }

    }
}
