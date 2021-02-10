namespace volreservation.API.Domain.Models
{
    public class Client {
        public int Id {get; set;}
        public Date DateOfBirth {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
    }
}