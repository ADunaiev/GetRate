namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoutePoint2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UnitTypeRoutePoints", "UnitType_Id", "dbo.UnitTypes");
            DropForeignKey("dbo.UnitTypeRoutePoints", "RoutePoint_Id", "dbo.RoutePoints");
            DropIndex("dbo.UnitTypeRoutePoints", new[] { "UnitType_Id" });
            DropIndex("dbo.UnitTypeRoutePoints", new[] { "RoutePoint_Id" });
            AddColumn("dbo.RoutePoints", "UnitType_Id", c => c.Int());
            CreateIndex("dbo.RoutePoints", "UnitType_Id");
            AddForeignKey("dbo.RoutePoints", "UnitType_Id", "dbo.UnitTypes", "Id");
            DropTable("dbo.UnitTypeRoutePoints");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UnitTypeRoutePoints",
                c => new
                    {
                        UnitType_Id = c.Int(nullable: false),
                        RoutePoint_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UnitType_Id, t.RoutePoint_Id });
            
            DropForeignKey("dbo.RoutePoints", "UnitType_Id", "dbo.UnitTypes");
            DropIndex("dbo.RoutePoints", new[] { "UnitType_Id" });
            DropColumn("dbo.RoutePoints", "UnitType_Id");
            CreateIndex("dbo.UnitTypeRoutePoints", "RoutePoint_Id");
            CreateIndex("dbo.UnitTypeRoutePoints", "UnitType_Id");
            AddForeignKey("dbo.UnitTypeRoutePoints", "RoutePoint_Id", "dbo.RoutePoints", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UnitTypeRoutePoints", "UnitType_Id", "dbo.UnitTypes", "Id", cascadeDelete: true);
        }
    }
}
