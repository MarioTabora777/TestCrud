using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace DataAccess
{
    public partial class TestCrudDBContext : DbContext
    {
        public TestCrudDBContext(string conectionstring)
            : base(conectionstring)
        {
            
        }

        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<role>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user1)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.id_document)
                .IsUnicode(false);
        }
    }
}
