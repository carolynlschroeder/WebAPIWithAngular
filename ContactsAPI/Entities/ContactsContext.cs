using System;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Entities
{
    public partial class ContactsContext : DbContext
    {
        public virtual DbSet<Contact> Contact { get; set; }

        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contact");
        }

    }
}