namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequestAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        FromCargoPackageId = c.Int(),
                        FromRoutePointId = c.Int(),
                        FromHandllingNeeded = c.Boolean(nullable: false),
                        ToCargoPackageId = c.Int(),
                        ToRoutePointId = c.Int(),
                        ToHandlingNeeded = c.Boolean(nullable: false),
                        CargoGW = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CargoVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.CargoPackages", t => t.FromCargoPackageId)
                .ForeignKey("dbo.CargoPackages", t => t.ToCargoPackageId)
                .ForeignKey("dbo.RoutePoints", t => t.FromRoutePointId)
                .ForeignKey("dbo.RoutePoints", t => t.ToRoutePointId)
                .Index(t => t.CompanyId)
                .Index(t => t.FromCargoPackageId)
                .Index(t => t.FromRoutePointId)
                .Index(t => t.ToCargoPackageId)
                .Index(t => t.ToRoutePointId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "ToRoutePointId", "dbo.RoutePoints");
            DropForeignKey("dbo.Requests", "FromRoutePointId", "dbo.RoutePoints");
            DropForeignKey("dbo.Requests", "ToCargoPackageId", "dbo.CargoPackages");
            DropForeignKey("dbo.Requests", "FromCargoPackageId", "dbo.CargoPackages");
            DropForeignKey("dbo.Requests", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Requests", new[] { "ToRoutePointId" });
            DropIndex("dbo.Requests", new[] { "ToCargoPackageId" });
            DropIndex("dbo.Requests", new[] { "FromRoutePointId" });
            DropIndex("dbo.Requests", new[] { "FromCargoPackageId" });
            DropIndex("dbo.Requests", new[] { "CompanyId" });
            DropTable("dbo.Requests");
        }
    }
}
