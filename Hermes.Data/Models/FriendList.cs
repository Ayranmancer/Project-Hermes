using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Data.Models
{
    public class FriendList
    {
        public string Id { get; set; } = null!;
        public string UserId{ get; set; }
        public string FriendId{ get; set; }
        public DateTime? MessageTime { get; set; } 
        public bool NewMessage { get; set; }

        public virtual User User { get; set; }
        public virtual User Friend { get; set; }


    }
}
