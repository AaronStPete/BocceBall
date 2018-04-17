namespace BocceBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFKAwayteam : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Games", "AwayTeamID");
            AddForeignKey("dbo.Games", "AwayTeamID", "dbo.Teams", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "AwayTeamID", "dbo.Teams");
            DropIndex("dbo.Games", new[] { "AwayTeamID" });
        }
    }
}
