#nullable disable
using Microsoft.EntityFrameworkCore;
using CRUT.Models;

namespace CRUT.Data
{
    public class CRUTContext : DbContext
    {
        public CRUTContext (DbContextOptions<CRUTContext> options)
            : base(options)
        {
        }

        public DbSet<Coin> Coin { get; set; }
    }
}
