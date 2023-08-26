namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteItems2 : DbMigration
    {
        public override void Up()
        {

            DropForeignKey("dbo.Handlings", "RoutePointId", "dbo.RoutePoints");
            RenameTable(name: "dbo.Handlings", newName: "RouteItems");
            DropIndex("dbo.RouteItems", new[] { "RoutePointId" });
            RenameColumn(table: "dbo.RouteItems", name: "RoutePointId", newName: "RoutePointInId");
            AddColumn("dbo.RouteItems", "RoutePointOutId", c => c.Int());
            AddColumn("dbo.RouteItems", "CargoPackageInId", c => c.Int());
            AddColumn("dbo.RouteItems", "CargoPackageOutId", c => c.Int());
            AlterColumn("dbo.RouteItems", "RoutePointInId", c => c.Int());
            CreateIndex("dbo.RouteItems", "RoutePointInId");
            CreateIndex("dbo.RouteItems", "RoutePointOutId");
            CreateIndex("dbo.RouteItems", "CargoPackageInId");
            CreateIndex("dbo.RouteItems", "CargoPackageOutId");
            AddForeignKey("dbo.RouteItems", "CargoPackageInId", "dbo.CargoPackages", "Id");
            AddForeignKey("dbo.RouteItems", "CargoPackageOutId", "dbo.CargoPackages", "Id");
            AddForeignKey("dbo.RouteItems", "RoutePointOutId", "dbo.RoutePoints", "Id");
            AddForeignKey("dbo.RouteItems", "RoutePointInId", "dbo.RoutePoints", "Id");

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RouteItems", "RoutePointInId", "dbo.RoutePoints");
            DropForeignKey("dbo.RouteItems", "RoutePointOutId", "dbo.RoutePoints");
            DropForeignKey("dbo.RouteItems", "CargoPackageOutId", "dbo.CargoPackages");
            DropForeignKey("dbo.RouteItems", "CargoPackageInId", "dbo.CargoPackages");
            DropIndex("dbo.RouteItems", new[] { "CargoPackageOutId" });
            DropIndex("dbo.RouteItems", new[] { "CargoPackageInId" });
            DropIndex("dbo.RouteItems", new[] { "RoutePointOutId" });
            DropIndex("dbo.RouteItems", new[] { "RoutePointInId" });
            AlterColumn("dbo.RouteItems", "RoutePointInId", c => c.Int(nullable: false));
            DropColumn("dbo.RouteItems", "CargoPackageOutId");
            DropColumn("dbo.RouteItems", "CargoPackageInId");
            DropColumn("dbo.RouteItems", "RoutePointOutId");
            RenameColumn(table: "dbo.RouteItems", name: "RoutePointInId", newName: "RoutePointId");
            CreateIndex("dbo.RouteItems", "RoutePointId");
            AddForeignKey("dbo.Handlings", "RoutePointId", "dbo.RoutePoints", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.RouteItems", newName: "Handlings");
        }
    }
}
