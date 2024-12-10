using Hermes.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Data.Configuration
{
    public class ConversationConfiguration : IEntityTypeConfiguration<Conversation>
    {
        public void Configure(EntityTypeBuilder<Conversation> builder)
        {
            builder.ToTable("Conversation");
            builder.Property(e=>e.Id).HasMaxLength(64).HasColumnName("Id");
            builder.Property(e=>e.Status).HasColumnName("Status");
            builder.Property(e=>e.Time).HasColumnType("datetime").HasColumnName("Time").IsRequired(false); 
            builder.Property(e => e.UserOne).HasMaxLength(64).HasColumnName("User_One");
            builder.Property(e => e.UserTwo).HasMaxLength(64).HasColumnName("User_Two");

            builder.HasOne(d => d.UserOneNavigation)
                .WithMany(p => p.ConversationUserOneNavigations)
                .HasForeignKey(d=>d.UserOne)
                .HasConstraintName("FK_Conversation_users");

            builder.HasOne(d => d.UserTwoNavigation)
                .WithMany(p => p.ConversationUserTwoNavigations)
                .HasForeignKey(d => d.UserTwo)
                .HasConstraintName("FK_Conversation_users1")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
