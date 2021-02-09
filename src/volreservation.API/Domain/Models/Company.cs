using System.Collections.Generic;
namespace volreservation.API

{
    public class Company {
        public int Id {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public string Name {get; set;}
        public string Sector {get; set;}

        public IList<Vol> Vols {get; set;} = new List<Vol>();
    }
}