namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsMovie : DbMigration
    {
        public override void Up()
        {
          
            
            CreateTable(
                "dbo.rental_movie",
                c => new
                    {
                        rental_id = c.Int(nullable: false, identity: true),
                        comment = c.String(maxLength: 255, unicode: false),
                        user_id = c.Int(nullable: false),
                        movie_id = c.Int(nullable: false),
                        transaction_date = c.DateTime(nullable: false),
                        transaction_price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.rental_id)
                .ForeignKey("dbo.movie", t => t.movie_id, cascadeDelete: true)
                .ForeignKey("dbo.user", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.movie_id);
            
            CreateTable(
                "dbo.sale_movie",
                c => new
                    {
                        sale_id = c.Int(nullable: false, identity: true),
                        comment = c.String(maxLength: 255, unicode: false),
                        user_id = c.Int(nullable: false),
                        movie_id = c.Int(nullable: false),
                        transaction_date = c.DateTime(nullable: false),
                        transaction_price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.sale_id)
                .ForeignKey("dbo.movie", t => t.movie_id, cascadeDelete: true)
                .ForeignKey("dbo.user", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.movie_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sale_movie", "user_id", "dbo.user");
            DropForeignKey("dbo.sale_movie", "movie_id", "dbo.movie");
            DropForeignKey("dbo.rental_movie", "user_id", "dbo.user");
            DropForeignKey("dbo.rental_movie", "movie_id", "dbo.movie");
            DropIndex("dbo.sale_movie", new[] { "movie_id" });
            DropIndex("dbo.sale_movie", new[] { "user_id" });
            DropIndex("dbo.rental_movie", new[] { "movie_id" });
            DropIndex("dbo.rental_movie", new[] { "user_id" });
            DropTable("dbo.sale_movie");
            DropTable("dbo.rental_movie");
          
        }
    }
}
