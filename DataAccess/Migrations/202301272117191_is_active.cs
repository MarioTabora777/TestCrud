namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class is_active : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.user", "is_active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.user", "is_active", c => c.Int());
        }
    }
}
