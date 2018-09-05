namespace NPCgenerator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addownerIDProf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personality", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Profession", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profession", "OwnerId");
            DropColumn("dbo.Personality", "OwnerId");
        }
    }
}
