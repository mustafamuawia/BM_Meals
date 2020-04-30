namespace BM_Meals
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BMMealsDBContext : DbContext
    {
        // Your context has been configured to use a 'BMMeals' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BM_Meals.BMMeals' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BMMeals' 
        // connection string in the application configuration file.
        public BMMealsDBContext()
            : base("BMMeals")
        {
            Database.SetInitializer<BMMealsDBContext>(new CreateDatabaseIfNotExists<BMMealsDBContext>());

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptDetails> ReceptsDetails { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
     
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}