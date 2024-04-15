using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using HermesCrypto;

namespace ChatServer.Net.IO
{
    class PacketBuilder
    {
        MemoryStream _ms;
        public PacketBuilder()
        {
            _ms = new MemoryStream();
        }
        public void WriteOpCode(byte opcode)
        {
            _ms.WriteByte(opcode);
        }
        public void WriteMessage(string msg)
        {
            //AES encryption
            byte[] encryptedMsg = AESLib.EncryptStringToBytes_Aes(msg);

            var encryptedMsgLength = encryptedMsg.Length;
            _ms.Write(BitConverter.GetBytes(encryptedMsgLength));
            _ms.Write(encryptedMsg);

            //log CLEARTEXT and CIPHERTEXT
            Console.WriteLine($"[Sent Original Text: {msg}]");
            Console.WriteLine($"[Sent Ciphertext: {Encoding.ASCII.GetString(encryptedMsg)}]");
        }

        public byte[] GetPacketBytes()
        {
            return _ms.ToArray();
        }
    }
}
