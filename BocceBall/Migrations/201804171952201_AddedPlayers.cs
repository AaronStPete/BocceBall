namespace BocceBall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Nickname = c.String(),
                        Number = c.Int(),
                        ThrowingArm = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
