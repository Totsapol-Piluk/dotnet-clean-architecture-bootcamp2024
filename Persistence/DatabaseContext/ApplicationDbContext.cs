using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DatabaseContext {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext() {

        }
        public ApplicationDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<BlogPost>(e => e.ToTable("BlogPost"));
            modelBuilder.Entity<Category>(e => e.ToTable("Category"));
            base.OnModelCreating(modelBuilder);
        }

    }
}
