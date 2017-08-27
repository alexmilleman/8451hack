namespace DataImport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransactionRecord
    {
        public int TransactionRecordID { get; set; }

        [Required]
        public string TransTime { get; set; }

        public int HouseholdID { get; set; }

        public int BasketID { get; set; }

        public int ProductID { get; set; }

        public virtual Basket Basket { get; set; }

        public virtual Household Household { get; set; }

        public virtual Product Product { get; set; }
    }
}
