namespace PASSION_PROJECT_MVP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "CustomerId", c => c.Int(nullable: true));
            CreateIndex("dbo.Rooms", "CustomerId");
            AddForeignKey("dbo.Rooms", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Rooms", new[] { "CustomerId" });
            DropColumn("dbo.Rooms", "CustomerId");
        }
    }
}
