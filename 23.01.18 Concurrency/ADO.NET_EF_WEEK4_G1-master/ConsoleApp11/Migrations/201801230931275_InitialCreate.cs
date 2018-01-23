namespace ConsoleApp11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentId = c.Int(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.InterpreterLanguageKnowledges",
                c => new
                    {
                        LanguageId = c.Int(nullable: false),
                        InterpreterId = c.Int(nullable: false),
                        LearnedDate = c.DateTime(),
                        LevelOfKnowledge = c.String(nullable: false),
                    })
                .PrimaryKey(t => new { t.LanguageId, t.InterpreterId })
                .ForeignKey("dbo.Interpreters", t => t.InterpreterId, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.LanguageId, cascadeDelete: true)
                .Index(t => t.LanguageId)
                .Index(t => t.InterpreterId);
            
            CreateTable(
                "dbo.Interpreters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LanguageName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InterpreterLanguageKnowledges", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.InterpreterLanguageKnowledges", "InterpreterId", "dbo.Interpreters");
            DropForeignKey("dbo.Courses", "ParentId", "dbo.Courses");
            DropIndex("dbo.InterpreterLanguageKnowledges", new[] { "InterpreterId" });
            DropIndex("dbo.InterpreterLanguageKnowledges", new[] { "LanguageId" });
            DropIndex("dbo.Courses", new[] { "ParentId" });
            DropTable("dbo.Languages");
            DropTable("dbo.Interpreters");
            DropTable("dbo.InterpreterLanguageKnowledges");
            DropTable("dbo.Courses");
        }
    }
}
