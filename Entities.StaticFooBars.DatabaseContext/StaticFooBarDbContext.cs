// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Entities.FooBars.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Entities.StaticFooBars.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for StaticFooBar entities</summary>
    public class StaticFooBarDbContext : FooBarDbContext
    {
        /// <summary>Constructs StaticFooBarDbContext EntityFrameworkCore database context using given options</summary>
        public StaticFooBarDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of StaticFooBar entities</summary>
        public DbSet<StaticFooBar> StaticFooBars { get; set; }

        /// <summary>Configures EntityFramework database creation - adds unique index to model</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StaticFooBar>().HasIndex(new StaticFooBar().GetUniqueIndex()).IsUnique();
        }
    }
}
