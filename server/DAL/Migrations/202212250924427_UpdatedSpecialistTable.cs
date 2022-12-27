namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedSpecialistTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Specialists", "Verified", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Specialists", "Verified");
        }
    }
}
