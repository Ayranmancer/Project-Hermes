using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Data.Models
{
    public partial class User
    {
        public User()
        {
            ConversationReplies = new HashSet<ConversationReply>();
            ConversationUserOneNavigations = new HashSet<Conversation>();
            ConversationUserTwoNavigations = new HashSet<Conversation>();
            FriendListUsers = new HashSet<FriendList>();
            FriendListFriends = new HashSet<FriendList>();
        }

        public string Id { get; set; } = null!;
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email{ get; set; }

        public virtual ICollection<ConversationReply> ConversationReplies {get; set; }
        public virtual ICollection<Conversation> ConversationUserOneNavigations { get; set; }
        public virtual ICollection<Conversation> ConversationUserTwoNavigations { get; set; }
        public virtual ICollection<FriendList> FriendListUsers { get; set; }
        public virtual ICollection<FriendList> FriendListFriends { get; set; }
    }
}
