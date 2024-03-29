﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

using Pandora.Domain;

namespace Pandora.Infrastructure.Persistence.EFCore.Entities
{
    public class User : IEntityTypeConfiguration<Domain.User>
    {
        public void Configure(EntityTypeBuilder<Domain.User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(user => user.Id);
            builder.Property(user => user.Id).HasColumnName("UserId");
            builder.Property(user => user.Id).HasConversion(
                        userId => userId.Value,
                        value => UniqueId.From(value))
                   .HasColumnName("UserId");

            builder.HasIndex(user => user.Email)
                   .IsUnique();

            builder.Property(user => user.Email)
                   .HasMaxLength(60)
                   .IsRequired();

            builder.Property(user => user.FirstName)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(user => user.LastName)
                   .HasMaxLength(30)
                   .IsRequired();
        }
    }
}
