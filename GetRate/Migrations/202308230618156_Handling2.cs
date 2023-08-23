namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Handling2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Handlings", name: "TMUT_Out_Id", newName: "TMUT_OutId");
            RenameIndex(table: "dbo.Handlings", name: "IX_TMUT_Out_Id", newName: "IX_TMUT_OutId");
            DropColumn("dbo.Handlings", "TMUT_InOut");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Handlings", "TMUT_InOut", c => c.Int());
            RenameIndex(table: "dbo.Handlings", name: "IX_TMUT_OutId", newName: "IX_TMUT_Out_Id");
            RenameColumn(table: "dbo.Handlings", name: "TMUT_OutId", newName: "TMUT_Out_Id");
        }
    }
}
