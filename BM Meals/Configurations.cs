using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Text;
using System.Data.SQLite;
using System.Data.SQLite.EF6.Migrations;


namespace BM_Meals
{
    class Configuration: DbMigrationsConfiguration<BMMealsDBContext>
    {
        public Configuration()
{
    AutomaticMigrationsEnabled = false;
    SetSqlGenerator("System.Data.SQLite.EF6", new 
       SQLiteMigrationSqlGenerator());// the Golden Key
}
    }
}
