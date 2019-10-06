using Microsoft.EntityFrameworkCore;
using MtG_Decktester.Models;

namespace MtG_Decktester.Data
{
    public class MtG_DecktesterContext : DbContext
    {
        public MtG_DecktesterContext()
        {
        }

        public MtG_DecktesterContext (DbContextOptions<MtG_DecktesterContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Card { get; set; }
    }
}
// The preceding code creates a DbSet<Card> property for the entity set.
// In Entity Framework terminology, an entity set typically corresponds to a database table.
// An entity corresponds to a row in the table.