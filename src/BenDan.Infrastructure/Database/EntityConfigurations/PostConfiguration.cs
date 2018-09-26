using BenDan.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenDan.Infrastructure.Database.EntityConfigurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x => x.Author).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.Title).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Body).IsRequired(false).HasColumnType("CLOB");
            builder.Property(x => x.Remark).IsRequired(false).HasMaxLength(200);
        }
    }
}
