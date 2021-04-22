using DailyScrum.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DailyScrum.Infrastructure.EntitiesConfiguration
{
    public class IssueConfiguration : BaseEntityConfiguration<Issue>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Issue> builder)
        {
            builder.HasOne(x => x.Project).WithMany(x => x.Issues).HasForeignKey(x => x.ProjectId);
            builder.HasOne(x => x.Sprint).WithMany(x => x.Issues).HasForeignKey(x => x.SprintId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Author).WithMany(x => x.Issues).HasForeignKey(x => x.AuthorId);
            builder.ToTable("Issues");
        }
    }
}

