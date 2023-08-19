namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Request3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "FromCityId", c => c.Int());
            AddColumn("dbo.Requests", "ToCityId", c => c.Int());
            AddColumn("dbo.Requests", "City_Id", c => c.Int());
            AddColumn("dbo.Requests", "City_Id1", c => c.Int());
            CreateIndex("dbo.Requests", "FromCityId");
            CreateIndex("dbo.Requests", "ToCityId");
            CreateIndex("dbo.Requests", "City_Id");
            CreateIndex("dbo.Requests", "City_Id1");
            AddForeignKey("dbo.Requests", "FromCityId", "dbo.Cities", "Id");
            AddForeignKey("dbo.Requests", "ToCityId", "dbo.Cities", "Id");
            AddForeignKey("dbo.Requests", "City_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Requests", "City_Id1", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "City_Id1", "dbo.Cities");
            DropForeignKey("dbo.Requests", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Requests", "ToCityId", "dbo.Cities");
            DropForeignKey("dbo.Requests", "FromCityId", "dbo.Cities");
            DropIndex("dbo.Requests", new[] { "City_Id1" });
            DropIndex("dbo.Requests", new[] { "City_Id" });
            DropIndex("dbo.Requests", new[] { "ToCityId" });
            DropIndex("dbo.Requests", new[] { "FromCityId" });
            DropColumn("dbo.Requests", "City_Id1");
            DropColumn("dbo.Requests", "City_Id");
            DropColumn("dbo.Requests", "ToCityId");
            DropColumn("dbo.Requests", "FromCityId");
        }
    }
}
