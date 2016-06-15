namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pending : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "User");
            RenameColumn(table: "dbo.User", name: "Id", newName: "UserId");
            AddColumn("dbo.User", "MyProperty", c => c.String());
            DropColumn("dbo.User", "ShippingAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "ShippingAddress", c => c.String());
            DropColumn("dbo.User", "MyProperty");
            RenameColumn(table: "dbo.User", name: "UserId", newName: "Id");
            RenameTable(name: "dbo.User", newName: "AspNetUsers");
        }
    }
}
