namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteItemRateadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RouteItemRates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        RouteItemId = c.Int(nullable: false),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Validity = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.RouteItems", t => t.RouteItemId, cascadeDelete: true)
                .Index(t => t.CompanyId)
                .Index(t => t.RouteItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RouteItemRates", "RouteItemId", "dbo.RouteItems");
            DropForeignKey("dbo.RouteItemRates", "CompanyId", "dbo.Companies");
            DropIndex("dbo.RouteItemRates", new[] { "RouteItemId" });
            DropIndex("dbo.RouteItemRates", new[] { "CompanyId" });
            DropTable("dbo.RouteItemRates");
        }
    }
}
