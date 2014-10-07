using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EF6MySQL
{
    public class MyModelContext : DbContext
    {
        public MyModelContext() : base("name=MyModel") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<MyModel> MyModel { get; set; }
    }
}

