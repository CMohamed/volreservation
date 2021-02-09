namespace volreservation.API
{
    public class Vol {
        public int Id {get; set;}
        public string Start {get; set;}
        public string Destination {get; set;}
        public long Max {get; set;}
        public long Min {get; set;}
    }
}