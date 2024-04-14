using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using HermesCrypto;

namespace ChatServer.Net.IO
{
    class PacketReader : BinaryReader
    {
        private NetworkStream _ns;
        public PacketReader(NetworkStream ns) : base(ns)
        {
            _ns = ns;
        }

        public string ReadMessage()
        {
            byte[] msgBuffer;
            var length = ReadInt32();
            msgBuffer = new byte[length];
            _ns.Read(msgBuffer, 0, length);
            var encryptedMsg = Encoding.ASCII.GetString(msgBuffer);

            //AES decryption
            var decryptedMsg = AESLib.DecryptStringFromBytes_Aes(msgBuffer);

            //log CIPHERTEXT and CLEARTEXT
            Console.WriteLine($"[Rcv Cleartext: {decryptedMsg}]");
            Console.WriteLine($"[Rcv Ciphertext: {encryptedMsg}]");

            return decryptedMsg;
        }
    }
}
