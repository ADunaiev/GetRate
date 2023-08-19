namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Request7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "FromCityId", c => c.Int());
            AddColumn("dbo.Requests", "ToCityId", c => c.Int());
            CreateIndex("dbo.Requests", "FromCityId");
            CreateIndex("dbo.Requests", "ToCityId");
            AddForeignKey("dbo.Requests", "FromCityId", "dbo.Cities", "Id");
            AddForeignKey("dbo.Requests", "ToCityId", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "ToCityId", "dbo.Cities");
            DropForeignKey("dbo.Requests", "FromCityId", "dbo.Cities");
            DropIndex("dbo.Requests", new[] { "ToCityId" });
            DropIndex("dbo.Requests", new[] { "FromCityId" });
            DropColumn("dbo.Requests", "ToCityId");
            DropColumn("dbo.Requests", "FromCityId");
        }
    }
}
