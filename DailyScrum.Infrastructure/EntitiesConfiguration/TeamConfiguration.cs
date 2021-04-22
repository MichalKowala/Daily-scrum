using DailyScrum.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Infrastructure.EntitiesConfiguration
{
    public class TeamConfiguration : BaseEntityConfiguration<Team>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Team> builder)
        {
            builder.HasMany(p => p.Users).WithOne(p=>p.Team);
            builder.ToTable("Teams");
        }
    }
}
