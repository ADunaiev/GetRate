namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Revolution1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RoutePoints", "UnitType_Id", "dbo.UnitTypes");
            DropIndex("dbo.RoutePoints", new[] { "UnitType_Id" });
            CreateTable(
                "dbo.RoutePointTransportModeUnitTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoutePointId = c.Int(nullable: false),
                        TransportModeUnitTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoutePoints", t => t.RoutePointId, cascadeDelete: true)
                .ForeignKey("dbo.TransportModeUnitTypes", t => t.TransportModeUnitTypeId, cascadeDelete: true)
                .Index(t => t.RoutePointId)
                .Index(t => t.TransportModeUnitTypeId);
            
            CreateTable(
                "dbo.TransportModeUnitTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransportModeId = c.Int(nullable: false),
                        UnitTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TransportModes", t => t.TransportModeId, cascadeDelete: true)
                .ForeignKey("dbo.UnitTypes", t => t.UnitTypeId, cascadeDelete: true)
                .Index(t => t.TransportModeId)
                .Index(t => t.UnitTypeId);
            
            CreateTable(
                "dbo.TransportationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransportModeUnitTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TransportModeUnitTypes", t => t.TransportModeUnitTypeId, cascadeDelete: true)
                .Index(t => t.TransportModeUnitTypeId);
            
            CreateTable(
                "dbo.TransportModes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameENG = c.String(),
                        NameUKR = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.RoutePoints", "UnitType_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RoutePoints", "UnitType_Id", c => c.Int());
            DropForeignKey("dbo.TransportModeUnitTypes", "UnitTypeId", "dbo.UnitTypes");
            DropForeignKey("dbo.TransportModeUnitTypes", "TransportModeId", "dbo.TransportModes");
            DropForeignKey("dbo.TransportationTypes", "TransportModeUnitTypeId", "dbo.TransportModeUnitTypes");
            DropForeignKey("dbo.RoutePointTransportModeUnitTypes", "TransportModeUnitTypeId", "dbo.TransportModeUnitTypes");
            DropForeignKey("dbo.RoutePointTransportModeUnitTypes", "RoutePointId", "dbo.RoutePoints");
            DropIndex("dbo.TransportationTypes", new[] { "TransportModeUnitTypeId" });
            DropIndex("dbo.TransportModeUnitTypes", new[] { "UnitTypeId" });
            DropIndex("dbo.TransportModeUnitTypes", new[] { "TransportModeId" });
            DropIndex("dbo.RoutePointTransportModeUnitTypes", new[] { "TransportModeUnitTypeId" });
            DropIndex("dbo.RoutePointTransportModeUnitTypes", new[] { "RoutePointId" });
            DropTable("dbo.TransportModes");
            DropTable("dbo.TransportationTypes");
            DropTable("dbo.TransportModeUnitTypes");
            DropTable("dbo.RoutePointTransportModeUnitTypes");
            CreateIndex("dbo.RoutePoints", "UnitType_Id");
            AddForeignKey("dbo.RoutePoints", "UnitType_Id", "dbo.UnitTypes", "Id");
        }
    }
}
