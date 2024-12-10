using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Data.Models
{
    public class Conversation
    {
        public Conversation()
        {
            ConversationReplies = new HashSet<ConversationReply>();
        }


        public string Id { get; set; } = null!;
        public string UserOne { get; set; }
        public string UserTwo { get; set; }
        public DateTime? Time { get; set; }
        public int Status { get; set; }

        public virtual User? UserOneNavigation { get; set; }
        public virtual User? UserTwoNavigation { get; set; }
        public virtual ICollection<ConversationReply> ConversationReplies { get; set; }
    }
}
