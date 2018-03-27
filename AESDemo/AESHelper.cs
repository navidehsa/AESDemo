using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AESDemo
{
    public class AesHelper
    {

        static AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
        public static AESModel providerData = new AESModel();
        
        public  AesHelper()
        {
            provider.KeySize = 256;
            provider.GenerateIV();
            provider.Mode = CipherMode.CBC;
            provider.Padding = PaddingMode.PKCS7;
        }
        public static AESModel Encrypt(string password, string clearText)
        {
            var obj = new AESModel();
            var Salt = Convert.FromBase64String("E1F53135E559C253");
            var key = new Rfc2898DeriveBytes(password,Salt,12000);
            provider.Key= key.GetBytes(provider.KeySize/8);
            ICryptoTransform transform = provider.CreateEncryptor();
            byte[] encryptedbyte =
                transform.TransformFinalBlock(Encoding.UTF8.GetBytes(clearText), 0, clearText.Length);
            obj.Payload = Convert.ToBase64String(encryptedbyte);
            return obj;
        }

        public static string Decrypt(string password, string cipherText)
        {
            var Salt = Convert.FromBase64String("E1F53135E559C253");
            var key = new Rfc2898DeriveBytes(password, Salt, 12000);
            provider.Key = key.GetBytes(provider.KeySize / 8);
            var transform = provider.CreateDecryptor();
            var encbyte = Convert.FromBase64String(cipherText);
            var decryptbyte = transform.TransformFinalBlock(encbyte, 0, encbyte.Length);
            var str = Encoding.UTF8.GetString(decryptbyte);
            return str;
        }


       


    }
}
