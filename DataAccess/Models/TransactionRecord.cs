//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionRecord
    {
        public int TransactionRecordID { get; set; }
        public string TransTime { get; set; }
        public int HouseholdID { get; set; }
        public int BasketID { get; set; }
        public int ProductID { get; set; }
    
        public virtual Household Household { get; set; }
        public virtual Basket Basket { get; set; }
        public virtual Product Product { get; set; }
    }
}