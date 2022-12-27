namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comment = c.String(nullable: false, maxLength: 256),
                        DatePosted = c.DateTime(nullable: false),
                        Likes = c.Int(nullable: false),
                        Dislikes = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        SpecialistId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Specialists", t => t.SpecialistId, cascadeDelete: true)
                .Index(t => t.QuestionId)
                .Index(t => t.SpecialistId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Query = c.String(nullable: false, maxLength: 256),
                        DatePosted = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Subtitle = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 256),
                        LastUpdatedAt = c.DateTime(nullable: false),
                        DifficultyId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Difficulties", t => t.DifficultyId, cascadeDelete: true)
                .Index(t => t.DifficultyId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.CourseEnrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        RatingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Ratings", t => t.RatingId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId)
                .Index(t => t.RatingId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Username = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Star = c.Int(nullable: false),
                        Meaning = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseInstructorMaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        InstructorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Specialists", t => t.InstructorId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.Specialists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Username = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseVideos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Video = c.String(nullable: false),
                        Serial = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        IsLockedId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.CouseVideoLocks", t => t.IsLockedId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.IsLockedId);
            
            CreateTable(
                "dbo.CouseVideoLocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsLocked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Difficulties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "SpecialistId", "dbo.Specialists");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "UserId", "dbo.Customers");
            DropForeignKey("dbo.Questions", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Courses", "DifficultyId", "dbo.Difficulties");
            DropForeignKey("dbo.CourseVideos", "IsLockedId", "dbo.CouseVideoLocks");
            DropForeignKey("dbo.CourseVideos", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseInstructorMaps", "InstructorId", "dbo.Specialists");
            DropForeignKey("dbo.CourseInstructorMaps", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseEnrollments", "RatingId", "dbo.Ratings");
            DropForeignKey("dbo.CourseEnrollments", "StudentId", "dbo.Customers");
            DropForeignKey("dbo.CourseEnrollments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.CourseVideos", new[] { "IsLockedId" });
            DropIndex("dbo.CourseVideos", new[] { "CourseId" });
            DropIndex("dbo.CourseInstructorMaps", new[] { "InstructorId" });
            DropIndex("dbo.CourseInstructorMaps", new[] { "CourseId" });
            DropIndex("dbo.CourseEnrollments", new[] { "RatingId" });
            DropIndex("dbo.CourseEnrollments", new[] { "CourseId" });
            DropIndex("dbo.CourseEnrollments", new[] { "StudentId" });
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropIndex("dbo.Courses", new[] { "DifficultyId" });
            DropIndex("dbo.Questions", new[] { "CategoryId" });
            DropIndex("dbo.Questions", new[] { "UserId" });
            DropIndex("dbo.Answers", new[] { "SpecialistId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.Difficulties");
            DropTable("dbo.CouseVideoLocks");
            DropTable("dbo.CourseVideos");
            DropTable("dbo.Specialists");
            DropTable("dbo.CourseInstructorMaps");
            DropTable("dbo.Ratings");
            DropTable("dbo.Customers");
            DropTable("dbo.CourseEnrollments");
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
