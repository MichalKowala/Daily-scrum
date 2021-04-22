using DailyScrum.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Infrastructure.EntitiesConfiguration
{
    public class SprintConfiguration : BaseEntityConfiguration<Sprint>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Sprint> builder)
        {
            builder.HasOne(x => x.Project).WithMany(x => x.Sprints).HasForeignKey(x => x.ProjectId).OnDelete(DeleteBehavior.Cascade);
            
            builder.ToTable("Sprints");
        }
    }
}
