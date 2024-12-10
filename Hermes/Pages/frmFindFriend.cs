using Hermes.Data;
using Hermes.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes.Pages
{
    public partial class frmFindFriend : Form
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public frmFindFriend()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName == txtFind.Text);
            
            
            if (user == null)
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Not found";
            }
            else
            {
                if (_context.FriendLists.FirstOrDefault(x => x.FriendId == user.Id && x.UserId == frmMainPage.userId) == null)
                {
                    FriendList friendList = new FriendList()
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserId = frmMainPage.userId,
                        FriendId = user.Id

                    };

                    _context.FriendLists.Add(friendList);
                    _context.SaveChanges();

                    lblInfo.ForeColor = Color.Green;
                    lblInfo.Text = "Success - Added in your friend list";

                }
                else
                {
                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "Already added to your friends list";
                }

            }
        }
    }
}
