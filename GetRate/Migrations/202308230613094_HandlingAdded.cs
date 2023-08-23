namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HandlingAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Handlings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TMUT_InId = c.Int(),
                        RoutePointId = c.Int(nullable: false),
                        TMUT_InOut = c.Int(),
                        TMUT_Out_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoutePoints", t => t.RoutePointId, cascadeDelete: true)
                .ForeignKey("dbo.TransportModeUnitTypes", t => t.TMUT_InId)
                .ForeignKey("dbo.TransportModeUnitTypes", t => t.TMUT_Out_Id)
                .Index(t => t.TMUT_InId)
                .Index(t => t.RoutePointId)
                .Index(t => t.TMUT_Out_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Handlings", "TMUT_Out_Id", "dbo.TransportModeUnitTypes");
            DropForeignKey("dbo.Handlings", "TMUT_InId", "dbo.TransportModeUnitTypes");
            DropForeignKey("dbo.Handlings", "RoutePointId", "dbo.RoutePoints");
            DropIndex("dbo.Handlings", new[] { "TMUT_Out_Id" });
            DropIndex("dbo.Handlings", new[] { "RoutePointId" });
            DropIndex("dbo.Handlings", new[] { "TMUT_InId" });
            DropTable("dbo.Handlings");
        }
    }
}
