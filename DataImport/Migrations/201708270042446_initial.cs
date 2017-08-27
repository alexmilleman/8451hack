namespace DataImport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        BasketID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BasketID);
            
            CreateTable(
                "dbo.TransactionRecords",
                c => new
                    {
                        TransactionRecordID = c.Int(nullable: false, identity: true),
                        TransTime = c.String(nullable: false),
                        HouseholdID = c.Int(nullable: false),
                        BasketID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionRecordID)
                .ForeignKey("dbo.Households", t => t.HouseholdID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.Baskets", t => t.BasketID)
                .Index(t => t.HouseholdID)
                .Index(t => t.BasketID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Households",
                c => new
                    {
                        HouseholdID = c.Int(nullable: false, identity: true),
                        TransactionRecordID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.HouseholdID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionRecords", "BasketID", "dbo.Baskets");
            DropForeignKey("dbo.TransactionRecords", "ProductID", "dbo.Products");
            DropForeignKey("dbo.TransactionRecords", "HouseholdID", "dbo.Households");
            DropIndex("dbo.TransactionRecords", new[] { "ProductID" });
            DropIndex("dbo.TransactionRecords", new[] { "BasketID" });
            DropIndex("dbo.TransactionRecords", new[] { "HouseholdID" });
            DropTable("dbo.Products");
            DropTable("dbo.Households");
            DropTable("dbo.TransactionRecords");
            DropTable("dbo.Baskets");
        }
    }
}
