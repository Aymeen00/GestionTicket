using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entity
{
    public class MyDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Agent> Agents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database provider and connection string
            optionsBuilder.UseSqlServer(@"Data Source=MYLAP\SQLEXPRESS;Initial Catalog=Gestion_Ticket;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True"
);
        }
    }
}