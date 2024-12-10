using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Data.Models
{
    public class ConversationReply
    {
        public string Id { get; set; } = null!;
        public string Reply { get; set; }
        public string UserIdFk{ get; set; }
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public string CIdFk { get; set; }

        public virtual Conversation CIdFkNavigation{ get; set; }
        public virtual User UserIdFkNavigation { get; set; }

    }
}
