using Estadio.Shared.Entities;

namespace Estadio.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            // Update database code
            await _context.Database.EnsureCreatedAsync();
            CheckTicketsAsync();
        }

        private async Task CheckTicketsAsync()
        {
            if(!_context.Ticket.Any())
            {
                for (int i = 0; i < 50000; i++)
                {
                    _context.Ticket.Add(new Ticket()
                    {
                        port = null,
                        used = false,
                        UsedDate = null,
                    });
                    _context.SaveChanges();
                }
            }
        }

    }

}
