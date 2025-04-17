namespace Example.WebApp.Models
{
    public record Person
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
