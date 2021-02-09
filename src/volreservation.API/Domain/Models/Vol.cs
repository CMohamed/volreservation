namespace volreservation.API
{
    public class Vol {
        public int Id {get; set;}
        public string Start {get; set;}
        public string Destination {get; set;}
        public int Price {get; set;}
        public long Max {get; set;}
        public long Min {get; set;}

        public int CompanyId {get; set;}
        public Company Company {get; set;}
    }
}