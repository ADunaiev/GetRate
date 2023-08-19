namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Request9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "FromHandlingNeeded", c => c.Boolean(nullable: false));
            DropColumn("dbo.Requests", "FromHandllingNeeded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Requests", "FromHandllingNeeded", c => c.Boolean(nullable: false));
            DropColumn("dbo.Requests", "FromHandlingNeeded");
        }
    }
}
