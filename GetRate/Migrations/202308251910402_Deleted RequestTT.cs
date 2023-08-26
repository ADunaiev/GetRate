namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedRequestTT : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RequestTransportationTypes", "RequestId", "dbo.Requests");
            DropForeignKey("dbo.RequestTransportationTypes", "TransportationTypeId", "dbo.TransportationTypes");
            DropIndex("dbo.RequestTransportationTypes", new[] { "RequestId" });
            DropIndex("dbo.RequestTransportationTypes", new[] { "TransportationTypeId" });
            DropTable("dbo.RequestTransportationTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RequestTransportationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestId = c.Int(nullable: false),
                        TransportationTypeId = c.Int(nullable: false),
                        Option = c.Int(nullable: false),
                        SubOption = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.RequestTransportationTypes", "TransportationTypeId");
            CreateIndex("dbo.RequestTransportationTypes", "RequestId");
            AddForeignKey("dbo.RequestTransportationTypes", "TransportationTypeId", "dbo.TransportationTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RequestTransportationTypes", "RequestId", "dbo.Requests", "Id", cascadeDelete: true);
        }
    }
}
