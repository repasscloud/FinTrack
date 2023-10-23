using FinTrack.Models.Clients;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed data
            BasicClient[] clientsToSeed = new BasicClient[10];

            for (int i = 1; i < 11; i++)
            {
                clientsToSeed[i - 1] = new BasicClient
                {
                    Id = i,
                    EntityName = $"Company {i} Pty Ltd",
                    ABN = $"01234567890",
                    ACN = $"123456789",
                    DirectorsName = $"Director Number {i}"
                };
            }

            modelBuilder.Entity<BasicClient>().HasData(clientsToSeed);
        }

        public DbSet<BasicClient> BasicClients { get; set; }
	}
}

