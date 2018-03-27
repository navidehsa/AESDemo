using System;
using System.Data;
using System.Runtime.Serialization.Json;

namespace AESDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string cleartext = "ssadadasdasdasdad asdasdasdasdieqouroiquew";
            AESModel encrypteddata = AesHelper.Encrypt("password", cleartext);
            string decrypt  = AesHelper.Decrypt("password",encrypteddata.Payload);
            if (decrypt == cleartext)
                Console.WriteLine(decrypt);
            else throw new SyntaxErrorException("Error");
            Console.ReadKey();
        }

    }
}
