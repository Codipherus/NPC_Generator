namespace NPCgenerator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class owneridadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "OwnerId");
        }
    }
}
