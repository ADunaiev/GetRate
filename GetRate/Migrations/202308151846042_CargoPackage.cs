namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CargoPackage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CargoPackages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CargoId = c.Int(nullable: false),
                        PackageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargoes", t => t.CargoId, cascadeDelete: true)
                .ForeignKey("dbo.Packages", t => t.PackageId, cascadeDelete: true)
                .Index(t => t.CargoId)
                .Index(t => t.PackageId);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameENG = c.String(),
                        NameUKR = c.String(),
                        GrossWeight = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CargoPackages", "PackageId", "dbo.Packages");
            DropForeignKey("dbo.CargoPackages", "CargoId", "dbo.Cargoes");
            DropIndex("dbo.CargoPackages", new[] { "PackageId" });
            DropIndex("dbo.CargoPackages", new[] { "CargoId" });
            DropTable("dbo.Packages");
            DropTable("dbo.CargoPackages");
        }
    }
}
