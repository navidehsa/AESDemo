using System;
using System.Security.Cryptography;

namespace AESDemo
{
    public class KeyDerivation
    {
        public KeyDerivation()
        {
            Function = "PBDKF2";
            WorkFactor = 12000;
            Salt = Convert.FromBase64String("E1F53135E559C253");//Replace with Getsalt when you have database
        }
        public string Function { get; set; }
        public int WorkFactor { get; set; }
        public byte[] Salt { get; set; }

        //private static byte[] GetSalt(int maximumSaltLength = 32)
        //{
        //    var salt = new byte[maximumSaltLength];
        //    using (var random = new RNGCryptoServiceProvider())
        //    {
        //        random.GetNonZeroBytes(salt);
        //    }

        //    return salt;
        //}

    }
}
