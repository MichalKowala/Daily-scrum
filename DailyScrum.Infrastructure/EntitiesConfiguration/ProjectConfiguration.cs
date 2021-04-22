using DailyScrum.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Infrastructure.EntitiesConfiguration
{
    public class ProjectConfiguration : BaseEntityConfiguration<Project>
    {
        public override void ConfigureEntity(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Project> builder)
        {
           // builder.HasMany(p => p.Sprints).WithOne(p => p.Project);
            builder.HasOne(p => p.Author).WithMany(p => p.Projects).HasForeignKey(x=>x.AuthorId);
            builder.ToTable("Projects");
        }
    }
}
