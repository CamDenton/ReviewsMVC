namespace CDentonReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        ReviewTitle = c.String(),
                        Rating = c.Int(nullable: false),
                        ReviewContent = c.String(),
                        PublishedDate = c.DateTime(nullable: false),
                        AuthorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatID = c.Int(nullable: false, identity: true),
                        CatName = c.String(),
                        ReviewID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CatID)
                .ForeignKey("dbo.Reviews", t => t.ReviewID, cascadeDelete: true)
                .Index(t => t.ReviewID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "ReviewID", "dbo.Reviews");
            DropForeignKey("dbo.Reviews", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Categories", new[] { "ReviewID" });
            DropIndex("dbo.Reviews", new[] { "AuthorID" });
            DropTable("dbo.Categories");
            DropTable("dbo.Reviews");
            DropTable("dbo.Authors");
        }
    }
}
