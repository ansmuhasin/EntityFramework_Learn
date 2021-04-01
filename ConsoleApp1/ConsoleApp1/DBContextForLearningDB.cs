using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace ConsoleApp1
{
    public partial class DBContextForLearningDB : DbContext
    {
        public DBContextForLearningDB(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}