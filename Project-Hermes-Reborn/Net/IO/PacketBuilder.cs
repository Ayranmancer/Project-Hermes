using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using HermesCrypto;
using System.Security.Cryptography.Xml;

namespace Project_Hermes_Reborn.Net.IO
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


            //---------------
            //NON-ENCRYPTED VERSION

            //var msgLength = msg.Length;
            //_ms.Write(BitConverter.GetBytes(msgLength));
            //_ms.Write(Encoding.ASCII.GetBytes(msg));
            //---------------
        }

        public byte [] GetPacketBytes() 
        { 
            return _ms.ToArray();
        }
    }
}
