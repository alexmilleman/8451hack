namespace Main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransactionRecord
    {
        public int Id { get; set; }

        public string householdKey { get; set; }

        public string basketId { get; set; }

        public string day { get; set; }

        public string productId { get; set; }

        public string quantity { get; set; }

        public string salesValue { get; set; }

        public string storeId { get; set; }

        public string couponMatchDisc { get; set; }

        public string couponDisc { get; set; }

        public string retailDisc { get; set; }

        public string transTime { get; set; }

        public string weekNo { get; set; }
    }
}
