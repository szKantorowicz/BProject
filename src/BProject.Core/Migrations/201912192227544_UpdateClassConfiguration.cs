namespace BProject.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateClassConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CategoryProducts", newName: "ProductCategory");
            DropForeignKey("dbo.Users", "Role_ID", "dbo.Roles");
            DropForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Customers", "UserID", "dbo.Users");
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "ProductID", "dbo.Products");
            DropIndex("dbo.Addresses", new[] { "CustomerID" });
            DropIndex("dbo.Customers", new[] { "UserID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropIndex("dbo.OrderItems", new[] { "ProductID" });
            DropIndex("dbo.Users", new[] { "Role_ID" });
            RenameColumn(table: "dbo.ProductCategory", name: "Category_ID", newName: "CategoryID");
            RenameColumn(table: "dbo.ProductCategory", name: "Product_ID", newName: "ProductID");
            RenameColumn(table: "dbo.Orders", name: "Status1_ID", newName: "StatusID");
            RenameIndex(table: "dbo.Orders", name: "IX_Status1_ID", newName: "IX_StatusID");
            RenameIndex(table: "dbo.ProductCategory", name: "IX_Product_ID", newName: "IX_ProductID");
            RenameIndex(table: "dbo.ProductCategory", name: "IX_Category_ID", newName: "IX_CategoryID");
            DropPrimaryKey("dbo.ProductCategory");
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.RoleID })
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.RoleID);
            
            AddColumn("dbo.Products", "Availability", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "CustomerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "CustomerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Addresses", "Postcode", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Addresses", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "UserName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "Phone", c => c.String(maxLength: 10));
            AlterColumn("dbo.Customers", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "CustomerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OrderItems", "OrderID", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderItems", "ProductID", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderItems", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.OrderItems", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.OrderItems", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderItems", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "Category", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "QuantityInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Categories", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.PaymentTypes", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Status", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Users", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Roles", "CreatedDate", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.ProductCategory", new[] { "ProductID", "CategoryID" });
            CreateIndex("dbo.Addresses", "CustomerID");
            CreateIndex("dbo.Customers", "UserID");
            CreateIndex("dbo.Orders", "CustomerID");
            CreateIndex("dbo.OrderItems", "OrderID");
            CreateIndex("dbo.OrderItems", "ProductID");
            CreateIndex("dbo.Users", "CustomerID");
            AddForeignKey("dbo.Users", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "UserID", "dbo.Users", "ID", cascadeDelete: false);
            AddForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders", "ID", cascadeDelete: true);
            AddForeignKey("dbo.OrderItems", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
            DropColumn("dbo.Orders", "Status");
            DropColumn("dbo.Products", "Avilability");
            DropColumn("dbo.Users", "Role_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Role_ID", c => c.Int());
            AddColumn("dbo.Products", "Avilability", c => c.Boolean());
            AddColumn("dbo.Orders", "Status", c => c.Int());
            DropForeignKey("dbo.OrderItems", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Customers", "UserID", "dbo.Users");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.UserRole", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.UserRole", "UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "CustomerID", "dbo.Customers");
            DropIndex("dbo.UserRole", new[] { "RoleID" });
            DropIndex("dbo.UserRole", new[] { "UserID" });
            DropIndex("dbo.Users", new[] { "CustomerID" });
            DropIndex("dbo.OrderItems", new[] { "ProductID" });
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Customers", new[] { "UserID" });
            DropIndex("dbo.Addresses", new[] { "CustomerID" });
            DropPrimaryKey("dbo.ProductCategory");
            AlterColumn("dbo.Roles", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Roles", "Name", c => c.String());
            AlterColumn("dbo.Users", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Status", "Name", c => c.String());
            AlterColumn("dbo.PaymentTypes", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Description", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Products", "QuantityInStock", c => c.Int());
            AlterColumn("dbo.Products", "Price", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Products", "Category", c => c.Int());
            AlterColumn("dbo.OrderItems", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.OrderItems", "Quantity", c => c.Int());
            AlterColumn("dbo.OrderItems", "TotalPrice", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.OrderItems", "UnitPrice", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.OrderItems", "ProductID", c => c.Int());
            AlterColumn("dbo.OrderItems", "OrderID", c => c.Int());
            AlterColumn("dbo.Orders", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Orders", "CustomerID", c => c.Int());
            AlterColumn("dbo.Customers", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "UserName", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            AlterColumn("dbo.Customers", "UserID", c => c.Int());
            AlterColumn("dbo.Addresses", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Addresses", "Postcode", c => c.String());
            AlterColumn("dbo.Addresses", "City", c => c.String());
            AlterColumn("dbo.Addresses", "Street", c => c.String());
            AlterColumn("dbo.Addresses", "CustomerID", c => c.Int());
            DropColumn("dbo.Users", "CustomerID");
            DropColumn("dbo.Products", "Availability");
            DropTable("dbo.UserRole");
            AddPrimaryKey("dbo.ProductCategory", new[] { "Category_ID", "Product_ID" });
            RenameIndex(table: "dbo.ProductCategory", name: "IX_CategoryID", newName: "IX_Category_ID");
            RenameIndex(table: "dbo.ProductCategory", name: "IX_ProductID", newName: "IX_Product_ID");
            RenameIndex(table: "dbo.Orders", name: "IX_StatusID", newName: "IX_Status1_ID");
            RenameColumn(table: "dbo.Orders", name: "StatusID", newName: "Status1_ID");
            RenameColumn(table: "dbo.ProductCategory", name: "ProductID", newName: "Product_ID");
            RenameColumn(table: "dbo.ProductCategory", name: "CategoryID", newName: "Category_ID");
            CreateIndex("dbo.Users", "Role_ID");
            CreateIndex("dbo.OrderItems", "ProductID");
            CreateIndex("dbo.OrderItems", "OrderID");
            CreateIndex("dbo.Orders", "CustomerID");
            CreateIndex("dbo.Customers", "UserID");
            CreateIndex("dbo.Addresses", "CustomerID");
            AddForeignKey("dbo.OrderItems", "ProductID", "dbo.Products", "ID");
            AddForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders", "ID");
            AddForeignKey("dbo.Customers", "UserID", "dbo.Users", "ID");
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "ID");
            AddForeignKey("dbo.Addresses", "CustomerID", "dbo.Customers", "ID");
            AddForeignKey("dbo.Users", "Role_ID", "dbo.Roles", "ID");
            RenameTable(name: "dbo.ProductCategory", newName: "CategoryProducts");
        }
    }
}
