namespace NPCgenerator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Sex", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Race", c => c.String(nullable: false));
            DropColumn("dbo.Character", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Character", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.Character", "Race");
            DropColumn("dbo.Character", "Sex");
        }
    }
}
