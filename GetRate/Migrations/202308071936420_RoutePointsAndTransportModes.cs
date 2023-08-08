namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoutePointsAndTransportModes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnitTypeRoutePoints",
                c => new
                    {
                        UnitType_Id = c.Int(nullable: false),
                        RoutePoint_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UnitType_Id, t.RoutePoint_Id })
                .ForeignKey("dbo.UnitTypes", t => t.UnitType_Id, cascadeDelete: true)
                .ForeignKey("dbo.RoutePoints", t => t.RoutePoint_Id, cascadeDelete: true)
                .Index(t => t.UnitType_Id)
                .Index(t => t.RoutePoint_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UnitTypeRoutePoints", "RoutePoint_Id", "dbo.RoutePoints");
            DropForeignKey("dbo.UnitTypeRoutePoints", "UnitType_Id", "dbo.UnitTypes");
            DropIndex("dbo.UnitTypeRoutePoints", new[] { "RoutePoint_Id" });
            DropIndex("dbo.UnitTypeRoutePoints", new[] { "UnitType_Id" });
            DropTable("dbo.UnitTypeRoutePoints");
        }
    }
}
