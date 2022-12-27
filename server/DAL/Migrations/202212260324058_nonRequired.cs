namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nonRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SpecialistTokens", "ExpiredAt", c => c.DateTime());
            AlterColumn("dbo.CustomerTokens", "ExpiredAt", c => c.DateTime());
            AlterColumn("dbo.AdminTokens", "ExpiredAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminTokens", "ExpiredAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CustomerTokens", "ExpiredAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SpecialistTokens", "ExpiredAt", c => c.DateTime(nullable: false));
        }
    }
}
