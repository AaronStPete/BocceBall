namespace BocceBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGamesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HomeTeamID = c.Int(nullable: false),
                        AwayTeamID = c.Int(nullable: false),
                        HomeTeamScore = c.Int(nullable: false),
                        AwayTeamScore = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teams", t => t.HomeTeamID)
                .Index(t => t.HomeTeamID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams");
            DropIndex("dbo.Games", new[] { "HomeTeamID" });
            DropTable("dbo.Games");
        }
    }
}
