namespace CodeFirstWithoutDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedAuthorID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "AuthorID" });
            RenameColumn(table: "dbo.Courses", name: "AuthorID", newName: "Author_AuthorID");
            AlterColumn("dbo.Courses", "Author_AuthorID", c => c.Int());
            CreateIndex("dbo.Courses", "Author_AuthorID");
            AddForeignKey("dbo.Courses", "Author_AuthorID", "dbo.Authors", "AuthorID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_AuthorID" });
            AlterColumn("dbo.Courses", "Author_AuthorID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Courses", name: "Author_AuthorID", newName: "AuthorID");
            CreateIndex("dbo.Courses", "AuthorID");
            AddForeignKey("dbo.Courses", "AuthorID", "dbo.Authors", "AuthorID", cascadeDelete: true);
        }
    }
}
