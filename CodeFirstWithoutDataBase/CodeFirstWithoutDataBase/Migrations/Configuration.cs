namespace CodeFirstWithoutDataBase.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstWithoutDataBase.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstWithoutDataBase.PlutoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.Authors.AddOrUpdate(a => a.Name,
            //    new Author
            //    {
            //        Name = "Ans",
            //        Courses = new List<Course> { new Course { Name = "Javascript", Description = "Beginner Javascript" } }
            //    });
        }
    }
}
