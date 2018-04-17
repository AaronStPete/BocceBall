namespace BocceBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFK2Team : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "TeamID", c => c.Int());
            CreateIndex("dbo.Players", "TeamID");
            AddForeignKey("dbo.Players", "TeamID", "dbo.Teams", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamID", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamID" });
            DropColumn("dbo.Players", "TeamID");
        }
    }
}
