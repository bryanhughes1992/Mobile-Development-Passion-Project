namespace PASSION_PROJECT_MVP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Houses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Rooms", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Houses", new[] { "CustomerId" });
            DropIndex("dbo.Rooms", new[] { "CustomerId" });
            AddColumn("dbo.Houses", "CustomerFirstName", c => c.String());
            AddColumn("dbo.Houses", "CustomerLastName", c => c.String());
            AddColumn("dbo.Houses", "PhoneNumber", c => c.String());
            AddColumn("dbo.Rooms", "DrywallRepair", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rooms", "DrywallInstallation", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rooms", "FloorInstallation", c => c.String());
            AddColumn("dbo.Rooms", "NewWindows", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rooms", "NewDoors", c => c.Boolean(nullable: false));
            DropColumn("dbo.Houses", "CustomerId");
            DropColumn("dbo.Rooms", "Drywall");
            DropColumn("dbo.Rooms", "Floor");
            DropColumn("dbo.Rooms", "Image");
            DropColumn("dbo.Rooms", "CustomerId");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            AddColumn("dbo.Rooms", "CustomerId", c => c.Int());
            AddColumn("dbo.Rooms", "Image", c => c.Binary());
            AddColumn("dbo.Rooms", "Floor", c => c.String());
            AddColumn("dbo.Rooms", "Drywall", c => c.String());
            AddColumn("dbo.Houses", "CustomerId", c => c.Int(nullable: false));
            DropColumn("dbo.Rooms", "NewDoors");
            DropColumn("dbo.Rooms", "NewWindows");
            DropColumn("dbo.Rooms", "FloorInstallation");
            DropColumn("dbo.Rooms", "DrywallInstallation");
            DropColumn("dbo.Rooms", "DrywallRepair");
            DropColumn("dbo.Houses", "PhoneNumber");
            DropColumn("dbo.Houses", "CustomerLastName");
            DropColumn("dbo.Houses", "CustomerFirstName");
            CreateIndex("dbo.Rooms", "CustomerId");
            CreateIndex("dbo.Houses", "CustomerId");
            AddForeignKey("dbo.Rooms", "CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Houses", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
    }
}
