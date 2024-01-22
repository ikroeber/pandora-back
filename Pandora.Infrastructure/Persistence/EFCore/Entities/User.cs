using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

using Pandora.Domain;
using Pandora.Domain.ValueObjects;

namespace Pandora.Infrastructure.Persistence.EFCore.Entities
{
    public class User : IEntityTypeConfiguration<Domain.Entities.User>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(user => user.UserId);

            builder.Property(user => user.UserId).HasConversion(
                        userId => userId.Value,
                        value => UserId.From(value))
                   .HasColumnName("UserId");

            builder.Property(user => user.Email).HasMaxLength(60);

            builder.Property(user => user.FirstName).HasMaxLength(30);
            builder.Property(user => user.LastName).HasMaxLength(30);
        }
    }
}
