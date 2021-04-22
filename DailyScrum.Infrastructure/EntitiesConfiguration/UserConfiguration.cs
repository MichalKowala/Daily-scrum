using DailyScrum.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DailyScrum.Infrastructure.EntitiesConfiguration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void ConfigureEntity(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(x => x.Team)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.TeamID)
                .OnDelete(DeleteBehavior.Cascade);
            builder.ToTable("Users");
        }
    }
}
