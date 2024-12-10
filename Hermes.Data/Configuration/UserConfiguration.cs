using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hermes.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hermes.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Id).IsRequired().HasMaxLength(64).HasColumnName("Id");
            builder.Property(e => e.Email).IsRequired().HasMaxLength(128).HasColumnName("Email");
            builder.Property(e => e.Password).IsRequired().HasColumnName("Password");
            builder.Property(e => e.UserName).IsRequired().HasMaxLength(64).HasColumnName("UserName");
        }
    }
}
