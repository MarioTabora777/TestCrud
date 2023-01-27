using DataAccess.DBModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DataAccess
{
    public partial class TestCrudDBContext : DbContext
    {

        internal static string Conectionstring;
        public TestCrudDBContext()
        : base("data source=Tadeo-Tabora;initial catalog=TestCrud;persist security info=True;user id=sa;password=Hol@Hol@888;MultipleActiveResultSets=True;App=EntityFramework")
      // : base(Conectionstring)
        {



        }

       

        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<sale_movie> sale_movie { get; set; }
        public virtual DbSet<rental_movie> rental_movie { get; set; }
        public virtual DbSet<movie> movie { get; set; }
        public virtual DbSet<genre> genre { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<genre>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e._user)
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

            modelBuilder.Entity<movie>()
               .Property(e => e.description)
               .IsUnicode(false);

            modelBuilder.Entity<rental_movie>()
             .Property(e => e.comment)
             .IsUnicode(false);

            modelBuilder.Entity<sale_movie>()
            .Property(e => e.comment)
            .IsUnicode(false);
        }
    }
}
