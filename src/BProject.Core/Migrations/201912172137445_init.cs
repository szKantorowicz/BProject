namespace BProject.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        Street = c.String(),
                        City = c.String(),
                        Postcode = c.String(),
                        Country = c.String(),
                        Level = c.Int(),
                        UpdatedDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        UpdatedDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        IsPayed = c.Boolean(),
                        PaymentTypeID = c.Int(),
                        Status = c.Int(),
                        UpdatedDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                        Status1_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentTypeID)
                .ForeignKey("dbo.Status", t => t.Status1_ID)
                .Index(t => t.CustomerID)
                .Index(t => t.PaymentTypeID)
                .Index(t => t.Status1_ID);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(),
                        ProductID = c.Int(),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        TotalPrice = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(),
                        UpdatedDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category = c.Int(),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Quantityinstock = c.Int(),
                        Avilability = c.Boolean(),
                        UpdatedDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        UpdatedDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                        Role_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Roles", t => t.Role_ID)
                .Index(t => t.Role_ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UpdatedDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CategoryProducts",
                c => new
                    {
                        Category_ID = c.Int(nullable: false),
                        Product_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_ID, t.Product_ID })
                .ForeignKey("dbo.Categories", t => t.Category_ID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ID, cascadeDelete: true)
                .Index(t => t.Category_ID)
                .Index(t => t.Product_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_ID", "dbo.Roles");
            DropForeignKey("dbo.Customers", "UserID", "dbo.Users");
            DropForeignKey("dbo.Orders", "Status1_ID", "dbo.Status");
            DropForeignKey("dbo.Orders", "PaymentTypeID", "dbo.PaymentTypes");
            DropForeignKey("dbo.OrderItems", "ProductID", "dbo.Products");
            DropForeignKey("dbo.CategoryProducts", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.CategoryProducts", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers");
            DropIndex("dbo.CategoryProducts", new[] { "Product_ID" });
            DropIndex("dbo.CategoryProducts", new[] { "Category_ID" });
            DropIndex("dbo.Users", new[] { "Role_ID" });
            DropIndex("dbo.OrderItems", new[] { "ProductID" });
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "Status1_ID" });
            DropIndex("dbo.Orders", new[] { "PaymentTypeID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Customers", new[] { "UserID" });
            DropIndex("dbo.Addresses", new[] { "CustomerID" });
            DropTable("dbo.CategoryProducts");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Status");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
