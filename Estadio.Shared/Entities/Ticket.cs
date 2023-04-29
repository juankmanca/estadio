namespace Estadio.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime? UsedDate { get; set; }
        public bool used { get; set; }
        public string? port { get; set; }
    }
}
