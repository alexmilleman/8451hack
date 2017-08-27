namespace DataImport.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TransactionEntities : DbContext
    {
        public TransactionEntities()
            : base("name=TransactionEntities")
        {
        }

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Household> Households { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TransactionRecord> TransactionRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basket>()
                .HasMany(e => e.TransactionRecords)
                .WithRequired(e => e.Basket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Household>()
                .HasMany(e => e.TransactionRecords)
                .WithRequired(e => e.Household)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.TransactionRecords)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
