using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using HermesCrypto;

namespace Project_Hermes_Reborn.Net.IO
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

            //AES decryption
            string msg = AESLib.DecryptStringFromBytes_Aes(msgBuffer);

            //NON-DECRYPT VERSION
            //var msg = Encoding.ASCII.GetString(msgBuffer);

            return msg;
        }
    }
}
