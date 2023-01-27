namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPropietiesRentMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.rental_movie", "is_returned", c => c.Boolean(nullable: false));
            AddColumn("dbo.rental_movie", "returned_date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.rental_movie", "returned_date");
            DropColumn("dbo.rental_movie", "is_returned");
        }
    }
}
