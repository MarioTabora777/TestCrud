namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genreMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.movie", "genre_id", c => c.Int());
            CreateIndex("dbo.movie", "genre_id");
            AddForeignKey("dbo.movie", "genre_id", "dbo.genre", "genre_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.movie", "genre_id", "dbo.genre");
            DropIndex("dbo.movie", new[] { "genre_id" });
            DropColumn("dbo.movie", "genre_id");
        }
    }
}
