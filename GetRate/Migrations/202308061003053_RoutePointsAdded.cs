namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoutePointsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoutePoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoutePoints", "CompanyId", "dbo.Companies");
            DropIndex("dbo.RoutePoints", new[] { "CompanyId" });
            DropTable("dbo.RoutePoints");
        }
    }
}
