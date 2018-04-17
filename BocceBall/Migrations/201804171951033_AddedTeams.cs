namespace BocceBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTeams : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mascot = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
        }
    }
}
