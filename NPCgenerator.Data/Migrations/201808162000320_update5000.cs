namespace NPCgenerator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update5000 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Race", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Race", "OwnerId");
        }
    }
}
