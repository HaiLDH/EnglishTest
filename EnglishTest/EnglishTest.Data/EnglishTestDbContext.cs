using EnglishTest.Model.Models;
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

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Level> Levels { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Result> Results { get; set; }

        public DbSet<TestKit> TestKits { get; set; }

        public DbSet<Unit> Units { get; set; }

        public DbSet<UserAdmin> UserAdmins { get; set; }

        public DbSet<UserCandidate> UserCandidates { get; set; }


        public static EnglishTestDbContext Create()
        {
            return new EnglishTestDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}
