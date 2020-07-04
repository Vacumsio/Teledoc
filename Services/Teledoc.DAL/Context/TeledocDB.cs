using Microsoft.EntityFrameworkCore;
using Teledoc.Domain.Entities.Clients;
using Teledoc.Domain.Entities.Founders;

namespace Teledoc.DAL.Context
{
    public class TeledocDB : DbContext
    {
        public TeledocDB(DbContextOptions<TeledocDB> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Founder> Founders { get; set; }

    }
}
