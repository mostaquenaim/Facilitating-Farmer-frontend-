namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
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
                "dbo.AdminSendMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustmerId = c.Int(nullable: false),
                        AdminId = c.Int(nullable: false),
                        Message = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustmerId, cascadeDelete: true)
                .Index(t => t.CustmerId)
                .Index(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminSendMessages", "CustmerId", "dbo.Customers");
            DropForeignKey("dbo.AdminSendMessages", "AdminId", "dbo.Admins");
            DropIndex("dbo.AdminSendMessages", new[] { "AdminId" });
            DropIndex("dbo.AdminSendMessages", new[] { "CustmerId" });
            DropTable("dbo.AdminSendMessages");
            DropTable("dbo.Admins");
        }
    }
}
