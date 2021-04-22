using DailyScrum.Infrastructure.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DailyScrum.Infrastructure.DatabaseContext
{
    public class DailyScrumDbContext : DbContext
    {
        public DailyScrumDbContext(DbContextOptions options) : base (options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new ProjectConfiguration())
                .ApplyConfiguration(new SprintConfiguration())
                .ApplyConfiguration(new IssueConfiguration())
                .ApplyConfiguration(new UserConfiguration())
                .ApplyConfiguration(new TeamConfiguration())
                .ApplyConfiguration(new CommentConfiguration());
        }
    }
}


