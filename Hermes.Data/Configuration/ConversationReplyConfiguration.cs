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
    public class ConversationReplyConfiguration : IEntityTypeConfiguration<ConversationReply>
    {
        public void Configure(EntityTypeBuilder<ConversationReply> builder)
        {
            builder.Property(e => e.Id).HasMaxLength(64).HasColumnName("id");
            builder.Property(e => e.CIdFk).HasMaxLength(64).HasColumnName("c_id_fk");
            builder.Property(e => e.Reply).HasColumnName("reply");
            builder.Property(e => e.Status).HasColumnName("status");
            builder.Property(e => e.Time).HasColumnType("datetime").HasColumnName("time");
            builder.Property(e => e.UserIdFk).HasMaxLength(64).HasColumnName("user_id_fk");

            builder.HasOne(d => d.CIdFkNavigation)
                .WithMany(p => p.ConversationReplies)
                .HasForeignKey(d => d.CIdFk)
                .HasConstraintName("FK_conversation_reply_conversation");

            builder.HasOne(d => d.UserIdFkNavigation)
                .WithMany(p => p.ConversationReplies)
                .HasForeignKey(d => d.UserIdFk)
                .HasConstraintName("FK_conversation_reply_users1")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
