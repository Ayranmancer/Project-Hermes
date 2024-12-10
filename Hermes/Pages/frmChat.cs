using Hermes.Data;
using Hermes.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes.Pages
{
    public partial class frmChat : Form
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private string friendId = "";
        private string friendName = "";
        private string? ConversationId = "";
        private string friendListId = "";

        private FriendList friendListSingle = new FriendList();
        private List<FriendList> friendList = new List<FriendList>();


        public frmChat()
        {
            InitializeComponent();
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            friendList = _context.FriendLists.Where(x => x.UserId == frmMainPage.userId).ToList();

            foreach (var item in friendList)
            {
                lstFriend.Items.Add(_context.Users.FirstOrDefault(x => x.Id == item.FriendId).UserName);
            }
        }
        void UpsertConversation()
        {
            Conversation conv = new Conversation();
            ConversationId = null;
            
            try
            {
                ConversationId = _context.Conversations.FirstOrDefault(x => x.UserOne == frmMainPage.userId && x.UserTwo == friendId).Id;
            }
            catch (Exception)
            {
                try
                {
                    ConversationId = _context.Conversations.FirstOrDefault(x => x.UserOne == friendId && x.UserTwo == frmMainPage.userId).Id;
                }
                catch (Exception)
                {
                }
            }
            

            if (ConversationId == null)
            {
                string guid = Guid.NewGuid().ToString();
                conv.Id = guid;
                conv.UserOne = frmMainPage.userId;
                conv.UserTwo = friendId;
                conv.Time = DateTime.Now;
                _context.Conversations.Add(conv);
                _context.SaveChanges();
                ConversationId = conv.Id;
            }
        }

        void UpsertConversationReply()
        {
            ConversationReply conversationReply = new ConversationReply();

            conversationReply.Id = Guid.NewGuid().ToString();
            conversationReply.Reply = EncryptAes(txtMessage.Text);
            conversationReply.CIdFk = ConversationId;
            conversationReply.Time = DateTime.Now;
            conversationReply.UserIdFk = frmMainPage.userId;

            _context.ConversationsReplies.Add(conversationReply);

            var myFriendFriendList = _context.FriendLists.FirstOrDefault(x => x.UserId == friendId && x.FriendId == frmMainPage.userId);
            if (myFriendFriendList == null)
            {
                MessageBox.Show("Karşı tarafın arkadaş listesinde olmadığınız için mesajınız iletilmedi"); 
            }
            else
            {
                
                _context.SaveChanges();
                txtMessage.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void SelectFriend()
        {
            var selectedFriend = lstFriend.SelectedItem;
            lstMessage.Items.Clear();

            if (!String.IsNullOrEmpty(selectedFriend.ToString()))
            {
                var friend = _context.Users.FirstOrDefault(x => x.UserName == selectedFriend);

                friendId = friend.Id;
                friendName = friend.UserName;
                this.Text = "Chat Page - " + friendName;
            }
            UpsertConversation();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UpsertConversationReply();
        }

        private void lstFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectFriend();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<ConversationReply> message = _context.ConversationsReplies.Where(x=>x.CIdFk == ConversationId).OrderBy(x=>x.Time).ToList();

            int dbMesajSayisi = message.Count;
            int frmMesajSayisi = lstMessage.Items.Count;
            int row = 0;
            string name = "";

            foreach (var item in message)
            {
                row++;
                if (row > frmMesajSayisi)
                {
                    if (item.UserIdFk == frmMainPage.userId)
                    {
                        name = frmMainPage.userName;
                    }
                    else if (item.UserIdFk == friendId)
                    {
                        name = friendName;
                    }

                    lstMessage.Items.Add(item.Time.ToShortDateString() + " " + item.Time.ToLongTimeString() + " - " + name +
                        " ==> " + DecryptAes(item.Reply));
                    frmMesajSayisi = lstMessage.Items.Count;
                }
            }

            AutoScroll();
        }

        private void AutoScroll()
        {
            int visibleItems = lstMessage.ClientSize.Height / lstMessage.ItemHeight;
            lstMessage.TopIndex = Math.Max(lstMessage.Items.Count - visibleItems + 1, 0);
        }



        // CRYPTOGRAPHY

        private static byte[] AESkey =
    {
                0x55, 0x66, 0x77, 0x32, 0x45, 0x21, 0x84, 0x74,
                0x09, 0x51, 0x37, 0x97, 0x64, 0x18, 0x14, 0x12
            };
        private static byte[] AESiv =
            {
                0x55, 0x66, 0x77, 0x32, 0x45, 0x21, 0x84, 0x74,
                0x09, 0x51, 0x37, 0x97, 0x64, 0x18, 0x14, 0x12
            };

        private static String EncryptAes(string plainText)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");

            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = AESkey;
                aesAlg.IV = AESiv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            string result = Convert.ToBase64String(encrypted);
            return result;
        }
        private static string DecryptAes(String strCipherText)
        {
            byte[] cipherText = Convert.FromBase64String(strCipherText);

            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = AESkey;
                aesAlg.IV = AESiv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

    }
}
