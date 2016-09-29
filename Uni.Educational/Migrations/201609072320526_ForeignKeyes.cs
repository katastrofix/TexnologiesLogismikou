namespace Uni.Educational.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        FieldID = c.Guid(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FieldID);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ProfessorID = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        Office = c.String(),
                        Field_FieldID = c.Guid(),
                    })
                .PrimaryKey(t => t.ProfessorID)
                .ForeignKey("dbo.Fields", t => t.Field_FieldID)
                .Index(t => t.Field_FieldID);
            
            CreateTable(
                "dbo.ProgrammingLanguages",
                c => new
                    {
                        ProgrammingLanguageID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProgrammingLanguageID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Assignee_StudentID = c.Guid(),
                        Language_ProgrammingLanguageID = c.Guid(),
                        SupervisingProfessor_ProfessorID = c.Guid(),
                        Technology_TechnologyStackID = c.Guid(),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.Students", t => t.Assignee_StudentID)
                .ForeignKey("dbo.ProgrammingLanguages", t => t.Language_ProgrammingLanguageID)
                .ForeignKey("dbo.Professors", t => t.SupervisingProfessor_ProfessorID)
                .ForeignKey("dbo.TechnologyStacks", t => t.Technology_TechnologyStackID)
                .Index(t => t.Assignee_StudentID)
                .Index(t => t.Language_ProgrammingLanguageID)
                .Index(t => t.SupervisingProfessor_ProfessorID)
                .Index(t => t.Technology_TechnologyStackID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MobilePhone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.TechnologyStacks",
                c => new
                    {
                        TechnologyStackID = c.Guid(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TechnologyStackID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "Technology_TechnologyStackID", "dbo.TechnologyStacks");
            DropForeignKey("dbo.Projects", "SupervisingProfessor_ProfessorID", "dbo.Professors");
            DropForeignKey("dbo.Projects", "Language_ProgrammingLanguageID", "dbo.ProgrammingLanguages");
            DropForeignKey("dbo.Projects", "Assignee_StudentID", "dbo.Students");
            DropForeignKey("dbo.Professors", "Field_FieldID", "dbo.Fields");
            DropIndex("dbo.Projects", new[] { "Technology_TechnologyStackID" });
            DropIndex("dbo.Projects", new[] { "SupervisingProfessor_ProfessorID" });
            DropIndex("dbo.Projects", new[] { "Language_ProgrammingLanguageID" });
            DropIndex("dbo.Projects", new[] { "Assignee_StudentID" });
            DropIndex("dbo.Professors", new[] { "Field_FieldID" });
            DropTable("dbo.TechnologyStacks");
            DropTable("dbo.Students");
            DropTable("dbo.Projects");
            DropTable("dbo.ProgrammingLanguages");
            DropTable("dbo.Professors");
            DropTable("dbo.Fields");
        }
    }
}
