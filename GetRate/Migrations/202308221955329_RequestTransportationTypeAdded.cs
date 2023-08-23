namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequestTransportationTypeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestTransportationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestId = c.Int(nullable: false),
                        TransportationTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requests", t => t.RequestId, cascadeDelete: true)
                .ForeignKey("dbo.TransportationTypes", t => t.TransportationTypeId, cascadeDelete: true)
                .Index(t => t.RequestId)
                .Index(t => t.TransportationTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequestTransportationTypes", "TransportationTypeId", "dbo.TransportationTypes");
            DropForeignKey("dbo.RequestTransportationTypes", "RequestId", "dbo.Requests");
            DropIndex("dbo.RequestTransportationTypes", new[] { "TransportationTypeId" });
            DropIndex("dbo.RequestTransportationTypes", new[] { "RequestId" });
            DropTable("dbo.RequestTransportationTypes");
        }
    }
}
