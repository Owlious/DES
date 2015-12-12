using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DES_En
{
    public class DES
    {
        public string InputStr { get; set; }
        public string OutputStr { get; set; }
        public string Key { get; set; }
        public string IV { get; set; }

        public bool Encrypt()
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            IV = Key;
            byte[] KeyBt = Encoding.UTF8.GetBytes(Key);
            byte[] IVBt = Encoding.UTF8.GetBytes(IV);
            
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] indata = Encoding.Default.GetBytes(InputStr);
                try
                {
                    CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(KeyBt, IVBt), CryptoStreamMode.Write);
                    cs.Write(indata, 0, indata.Length);
                    cs.FlushFinalBlock();
                    OutputStr = Convert.ToBase64String(ms.ToArray());
                    return true;
                }
                catch
                {
                    throw;
                }
            }
        }
        public bool Decrypt()
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            IV = Key;
            byte[] KeyBt = Encoding.UTF8.GetBytes(Key);
            byte[] IVBt = Encoding.UTF8.GetBytes(IV);

            using (MemoryStream ms = new MemoryStream())
            {
                byte[] indata = Convert.FromBase64String(InputStr);
                try
                {
                    CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(KeyBt, IVBt), CryptoStreamMode.Write);
                    cs.Write(indata, 0, indata.Length);
                    cs.FlushFinalBlock();
                    OutputStr = Encoding.Default.GetString(ms.ToArray());
                    return true;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
