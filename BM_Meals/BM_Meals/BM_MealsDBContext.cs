namespace BM_Meals
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;
    using System.Linq;
    

    public class BM_MealsDBContext : DbContext
    {
        // Your context has been configured to use a 'BM_Meals' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BM_Meals.BM_Meals' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BM_Meals' 
        // connection string in the application configuration file.
        public BM_MealsDBContext()
            : base("BM_MealsDBConnectionString")
        {
            Database.SetInitializer<BM_MealsDBContext>(new CreateDatabaseIfNotExists<BM_MealsDBContext>());

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BM_MealsDBContext, ContextMigrationConfiguration>(true));
        }

        // DbSets
    

    internal sealed class ContextMigrationConfiguration : DbMigrationsConfiguration<BM_MealsDBContext>
    {
        public ContextMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());

        }
    }

    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Waiter> Waiters { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}