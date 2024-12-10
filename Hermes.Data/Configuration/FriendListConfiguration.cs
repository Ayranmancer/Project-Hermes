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
    public class FriendListConfiguration : IEntityTypeConfiguration<FriendList>
    {
        public void Configure(EntityTypeBuilder<FriendList> builder)
        {
            builder.ToTable("FriendList");
            builder.Property(e=>e.Id).HasMaxLength(64);
            builder.Property(e => e.FriendId).HasMaxLength(64);
            builder.Property(e => e.MessageTime).HasColumnType("datetime").IsRequired(false); 

            builder.HasOne(d => d.User)
                .WithMany(p => p.FriendListUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_FriendList_users");

            builder.HasOne(d => d.Friend)
                .WithMany(p => p.FriendListFriends)
                .HasForeignKey(d => d.FriendId)
                .HasConstraintName("FK_FriendList_users1")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
