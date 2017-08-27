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
        
        public virtual DbSet<TransactionRecord> TransactionRecords { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
