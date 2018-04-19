using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Data
{
    public class EnglishTestDbContext : DbContext
    {
        public EnglishTestDbContext() : base("EnglishTestConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        //public DbSet<ClassFA> ClassFA { get; set; }


        public static EnglishTestDbContext Create()
        {
            return new EnglishTestDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}
