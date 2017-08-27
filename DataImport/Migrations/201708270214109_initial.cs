namespace DataImport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        householdKey = c.Int(nullable: false),
                        basketId = c.Long(nullable: false),
                        day = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        salesValue = c.Double(nullable: false),
                        storeId = c.Int(nullable: false),
                        couponMatchDisc = c.Int(nullable: false),
                        couponDisc = c.Int(nullable: false),
                        retailDisc = c.Int(nullable: false),
                        transTime = c.Int(nullable: false),
                        weekNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TransactionRecords");
        }
    }
}
