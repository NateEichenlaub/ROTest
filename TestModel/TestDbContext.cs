using System.Data.Entity;

namespace TestModel
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(string name) : base(name) { }
        public TestDbContext() { }

        public DbSet<TestObject> TestObjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new TestDbInitialiser()); 
        }
    }
}