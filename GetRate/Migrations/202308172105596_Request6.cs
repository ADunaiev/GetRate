namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Request6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Requests", "FromCityId", "dbo.Cities");
            DropForeignKey("dbo.Requests", "ToCityId", "dbo.Cities");
            DropForeignKey("dbo.Requests", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Requests", "City_Id1", "dbo.Cities");
            DropIndex("dbo.Requests", new[] { "FromCityId" });
            DropIndex("dbo.Requests", new[] { "ToCityId" });
            DropIndex("dbo.Requests", new[] { "City_Id" });
            DropIndex("dbo.Requests", new[] { "City_Id1" });
            DropColumn("dbo.Requests", "FromCityId");
            DropColumn("dbo.Requests", "ToCityId");
            DropColumn("dbo.Requests", "City_Id");
            DropColumn("dbo.Requests", "City_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Requests", "City_Id1", c => c.Int());
            AddColumn("dbo.Requests", "City_Id", c => c.Int());
            AddColumn("dbo.Requests", "ToCityId", c => c.Int());
            AddColumn("dbo.Requests", "FromCityId", c => c.Int());
            CreateIndex("dbo.Requests", "City_Id1");
            CreateIndex("dbo.Requests", "City_Id");
            CreateIndex("dbo.Requests", "ToCityId");
            CreateIndex("dbo.Requests", "FromCityId");
            AddForeignKey("dbo.Requests", "City_Id1", "dbo.Cities", "Id");
            AddForeignKey("dbo.Requests", "City_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Requests", "ToCityId", "dbo.Cities", "Id");
            AddForeignKey("dbo.Requests", "FromCityId", "dbo.Cities", "Id");
        }
    }
}
