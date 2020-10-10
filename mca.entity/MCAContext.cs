using mca.entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace mca.entity
{
    public interface IMCAContext
    {
        Task<int> SaveChangesAsync();

        DbSet<Contact> Contacts { get; set; }
    }
    public class MCAContext : DbContext, IMCAContext
    {
        public MCAContext(DbContextOptions<MCAContext> options)
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        public Task<int> SaveChangesAsync() => base.SaveChangesAsync();
    }
}
