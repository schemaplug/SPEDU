using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SPEDU.Data
{
    public class AppDbContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }

    #region Initial data

    // Change the base class as follows if you want to drop and create the database during development:
    //public class DbInitializer : DropCreateDatabaseAlways<AppDbContext>
    //public class DbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    public class DbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            

        }
    }

    #endregion
}
