namespace CodeFirstWithoutDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFluentAPILengthAndForiegnKey : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagCourses", newName: "Coursetags");
            DropForeignKey("dbo.Courses", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_AuthorID" });
            RenameColumn(table: "dbo.Courses", name: "Author_AuthorID", newName: "AuthorID");
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        CoverID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CoverID)
                .ForeignKey("dbo.Courses", t => t.CoverID)
                .Index(t => t.CoverID);
            
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Courses", "AuthorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "AuthorID");
            AddForeignKey("dbo.Courses", "AuthorID", "dbo.Authors", "AuthorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "AuthorID", "dbo.Authors");
            DropForeignKey("dbo.Covers", "CoverID", "dbo.Courses");
            DropIndex("dbo.Covers", new[] { "CoverID" });
            DropIndex("dbo.Courses", new[] { "AuthorID" });
            AlterColumn("dbo.Courses", "AuthorID", c => c.Int());
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            DropTable("dbo.Covers");
            RenameColumn(table: "dbo.Courses", name: "AuthorID", newName: "Author_AuthorID");
            CreateIndex("dbo.Courses", "Author_AuthorID");
            AddForeignKey("dbo.Courses", "Author_AuthorID", "dbo.Authors", "AuthorID");
            RenameTable(name: "dbo.Coursetags", newName: "TagCourses");
        }
    }
}
