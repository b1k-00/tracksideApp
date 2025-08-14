namespace tracksideApp00.Domain
{
    public class Crossing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public IList<TrainReport> Reports { get; set; } = new List<TrainReport>();
    }
}
