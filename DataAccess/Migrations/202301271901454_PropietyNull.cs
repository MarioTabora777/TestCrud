namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropietyNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.rental_movie", "returned_date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.rental_movie", "returned_date", c => c.DateTime(nullable: false));
        }
    }
}
