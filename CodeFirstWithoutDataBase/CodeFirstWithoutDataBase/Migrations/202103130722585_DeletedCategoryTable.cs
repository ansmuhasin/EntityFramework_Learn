namespace CodeFirstWithoutDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo._Categories",
                c => new
                {
                    CategoryID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.CategoryID);
            Sql("Insert into _Categories (Name) Select Name From Categories");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            Sql("Insert into Categories (Name) Select Name From _Categories");
            DropTable("dbo._Categories");
        }
    }
}
