namespace CodeFirstWithoutDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedCategoryForiegnRelationFromCourses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_CategoryID" });
            DropColumn("dbo.Courses", "Category_CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Courses", "Category_CategoryID");
            AddForeignKey("dbo.Courses", "Category_CategoryID", "dbo.Categories", "CategoryID");
        }
    }
}
