namespace MU_Clubs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        From = c.String(nullable: false),
                        To = c.String(nullable: false),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emails");
        }
    }
}
