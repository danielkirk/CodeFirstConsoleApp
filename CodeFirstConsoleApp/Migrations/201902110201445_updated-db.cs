namespace CodeFirstConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateddb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        GradeId = c.Int(nullable: false),
                        Grade_GradeId = c.Int(),
                        StudentID = c.Int(nullable: false),
                        StudentName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.GradeId)
                .ForeignKey("dbo.Grades", t => t.GradeId)
                .ForeignKey("dbo.Grades", t => t.Grade_GradeId)
                .Index(t => t.GradeId)
                .Index(t => t.Grade_GradeId);
            
            CreateTable(
                "dbo.Classroom",
                c => new
                    {
                        GradeId = c.Int(nullable: false),
                        ClassroomNumber = c.Int(nullable: false),
                        Teacher = c.String(),
                    })
                .PrimaryKey(t => t.GradeId)
                .ForeignKey("dbo.Students", t => t.GradeId)
                .Index(t => t.GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classroom", "GradeId", "dbo.Students");
            DropForeignKey("dbo.Students", "Grade_GradeId", "dbo.Grades");
            DropForeignKey("dbo.Students", "GradeId", "dbo.Grades");
            DropIndex("dbo.Classroom", new[] { "GradeId" });
            DropIndex("dbo.Students", new[] { "Grade_GradeId" });
            DropIndex("dbo.Students", new[] { "GradeId" });
            DropTable("dbo.Classroom");
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
