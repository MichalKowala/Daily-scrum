using DailyScrum.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DailyScrum.Infrastructure.EntitiesConfiguration
{
    public class CommentConfiguration : BaseEntityConfiguration<Comment>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(x => x.Author).WithMany(x => x.Comments).HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Issue).WithMany(x => x.Comments).HasForeignKey(x => x.IssueId);
            builder.ToTable("Comments");
        }
    }
}
