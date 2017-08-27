namespace DataImport.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Main.Models;

    public partial class TransactionEntities : DbContext
    {
        public TransactionEntities()
            : base("name=TransactionEntities")
        {
        }

        public virtual DbSet<ProductRecommendation> ProductRecommendations { get; set; }
        public virtual DbSet<TransactionRecord> TransactionRecords { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
