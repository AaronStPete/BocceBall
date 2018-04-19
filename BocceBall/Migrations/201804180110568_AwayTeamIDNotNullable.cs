namespace BocceBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AwayTeamIDNotNullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams");
            DropIndex("dbo.Games", new[] { "HomeTeamID" });
            AlterColumn("dbo.Games", "HomeTeamID", c => c.Int(nullable: false));
            CreateIndex("dbo.Games", "HomeTeamID");
            AddForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams");
            DropIndex("dbo.Games", new[] { "HomeTeamID" });
            AlterColumn("dbo.Games", "HomeTeamID", c => c.Int());
            CreateIndex("dbo.Games", "HomeTeamID");
            AddForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams", "ID");
        }
    }
}
