namespace BM_Meals
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinishDbTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 2147483647),
                        Status = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        ItemName = c.String(maxLength: 2147483647),
                        CategoryID = c.Int(nullable: false),
                        SellPrice = c.Double(nullable: false, storeType: "real"),
                        Cost = c.Double(nullable: false, storeType: "real"),
                        Status = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.ItemID);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ReceiptID = c.Int(nullable: false, identity: true),
                        ReceiptSerial = c.String(maxLength: 2147483647),
                        UserID = c.Int(nullable: false),
                        Total = c.Double(nullable: false, storeType: "real"),
                        ReceiptDate = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.ReceiptID);
            
            CreateTable(
                "dbo.ReceiptDetails",
                c => new
                    {
                        ReceiptDetailsID = c.Int(nullable: false, identity: true),
                        ReceiptID = c.Int(nullable: false),
                        ItemID = c.Int(nullable: false),
                        ItemName = c.Int(nullable: false),
                        SellPrice = c.Double(nullable: false, storeType: "real"),
                        Cost = c.Double(nullable: false, storeType: "real"),
                        Quantity = c.Double(nullable: false, storeType: "real"),
                        Total = c.Double(nullable: false, storeType: "real"),
                        Status = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.ReceiptDetailsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReceiptDetails");
            DropTable("dbo.Receipts");
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}
