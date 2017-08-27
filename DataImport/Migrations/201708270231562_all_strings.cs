namespace DataImport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all_strings : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TransactionRecords", "householdKey", c => c.String());
            AlterColumn("dbo.TransactionRecords", "basketId", c => c.String());
            AlterColumn("dbo.TransactionRecords", "day", c => c.String());
            AlterColumn("dbo.TransactionRecords", "productId", c => c.String());
            AlterColumn("dbo.TransactionRecords", "quantity", c => c.String());
            AlterColumn("dbo.TransactionRecords", "salesValue", c => c.String());
            AlterColumn("dbo.TransactionRecords", "storeId", c => c.String());
            AlterColumn("dbo.TransactionRecords", "couponMatchDisc", c => c.String());
            AlterColumn("dbo.TransactionRecords", "couponDisc", c => c.String());
            AlterColumn("dbo.TransactionRecords", "retailDisc", c => c.String());
            AlterColumn("dbo.TransactionRecords", "transTime", c => c.String());
            AlterColumn("dbo.TransactionRecords", "weekNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TransactionRecords", "weekNo", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "transTime", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "retailDisc", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "couponDisc", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "couponMatchDisc", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "storeId", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "salesValue", c => c.Double(nullable: false));
            AlterColumn("dbo.TransactionRecords", "quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "productId", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "day", c => c.Int(nullable: false));
            AlterColumn("dbo.TransactionRecords", "basketId", c => c.Long(nullable: false));
            AlterColumn("dbo.TransactionRecords", "householdKey", c => c.Int(nullable: false));
        }
    }
}
