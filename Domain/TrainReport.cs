namespace tracksideApp00.Domain
{
    public class TrainReport
    {
        public int id {  get; set; }
        public int CrossingId { get; set; }
        public Crossing Crossing { get; set; }
        public DateTime ReportedAt { get; set; }

        public DateTime ClearedAt { get; set; }

    }
}
