namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newlyAddedDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpecialistTokens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SpecialistId = c.Int(nullable: false),
                        TokenKey = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Specialists", t => t.SpecialistId, cascadeDelete: true)
                .Index(t => t.SpecialistId);
            
            CreateTable(
                "dbo.CustomerTokens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TokenKey = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.AdminTokens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdminId = c.Int(nullable: false),
                        TokenKey = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminTokens", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.CustomerTokens", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.SpecialistTokens", "SpecialistId", "dbo.Specialists");
            DropIndex("dbo.AdminTokens", new[] { "AdminId" });
            DropIndex("dbo.CustomerTokens", new[] { "CustomerId" });
            DropIndex("dbo.SpecialistTokens", new[] { "SpecialistId" });
            DropTable("dbo.AdminTokens");
            DropTable("dbo.CustomerTokens");
            DropTable("dbo.SpecialistTokens");
        }
    }
}
