using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace WindowsFormsAPP.Models
{
    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());
        }

        public virtual DbSet<ContactsTable> ContactsTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactsTable>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<ContactsTable>()
                .Property(e => e.quantity)
                .IsFixedLength();

            modelBuilder.Entity<ContactsTable>()
                .Property(e => e.price)
                .IsFixedLength();

            modelBuilder.Entity<ContactsTable>()
                .Property(e => e.category)
                .IsFixedLength();
        }
    }
}
