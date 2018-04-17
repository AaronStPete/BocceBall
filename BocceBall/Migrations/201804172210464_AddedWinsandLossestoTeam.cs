namespace BocceBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWinsandLossestoTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Wins", c => c.Int());
            AddColumn("dbo.Teams", "Losses", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Losses");
            DropColumn("dbo.Teams", "Wins");
        }
    }
}
