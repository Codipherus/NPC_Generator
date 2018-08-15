namespace NPCgenerator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.Character", "Sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Character", "Sex", c => c.Int(nullable: false));
            DropColumn("dbo.Character", "Gender");
        }
    }
}
