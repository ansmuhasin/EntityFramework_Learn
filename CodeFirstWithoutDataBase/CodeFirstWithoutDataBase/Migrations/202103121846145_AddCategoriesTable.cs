namespace CodeFirstWithoutDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            Sql("Insert into Categories values (1, 'Web Development')");
            Sql("Insert into Categories values (2, 'Programming Language')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
