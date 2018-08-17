namespace NPCgenerator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        EquipmentId = c.Int(nullable: false, identity: true),
                        EquipmentName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EquipmentId);
            
            CreateTable(
                "dbo.Personality",
                c => new
                    {
                        PersonalityId = c.Int(nullable: false, identity: true),
                        PersonalityName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonalityId);
            
            CreateTable(
                "dbo.Profession",
                c => new
                    {
                        ProfessionId = c.Int(nullable: false, identity: true),
                        ProfessionName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProfessionId);
            
            CreateTable(
                "dbo.Race",
                c => new
                    {
                        RaceId = c.Int(nullable: false, identity: true),
                        RaceName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RaceId);
            
            DropTable("dbo.Character");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Character",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        Gender = c.Int(nullable: false),
                        Race = c.String(nullable: false),
                        Profession = c.String(nullable: false),
                        Equipment = c.String(nullable: false),
                        Personality = c.String(nullable: false),
                        Hostile = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterId);
            
            DropTable("dbo.Race");
            DropTable("dbo.Profession");
            DropTable("dbo.Personality");
            DropTable("dbo.Equipment");
        }
    }
}
