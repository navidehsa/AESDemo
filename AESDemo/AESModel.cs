using System;
using System.Collections.Generic;
using System.Text;

namespace AESDemo
{
    public class AESModel
    {
        public AESModel()
        {
            Algoritm = "aes-gcm-256";
            Version = "1";
        }
        public string Version { get; set; }
        public string IV { get; set; }
        public string Algoritm { get; set; }
        public KeyDerivation Keydivertion { get; set; }
        public  string Payload { get; set; }
        

    }
}
