using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filemanager
{
    public static class Cryptfunc
    {
        static string publickey = "<RSAKeyValue><Modulus>0LS7PqpBXoZfGV+XAscQlDhrCU5oCVAnRZeYW9hUgSIcCHxtBmrLGr6nVjisoewzhZntg+susmidACqxIP+IBy3YFuQy0u+V/y1Gd72gSZ91ykKsj2RoP+wDM4CUMiyr44ZvZpc5C0Mez+o6qWEZY5zxvyNe55d/K7kaocf6U+dPGd+TsZcHSEUDSnt6dKGcltCl/ZS33v6G3xOYz1ItJ0zvrnGI94n9cYbtF5S6hBxImK7wQugKwtxBbTwPRr7ha30Otfo8N1FPovcibTvTD5IBhuWLLVkTT3/Jf9nzm3rg+vM0BgaTWyblCl/h4c5aTYYrH6a2PKCOK5HrFjfPdQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        static string privatekey = "<RSAKeyValue><Modulus>0LS7PqpBXoZfGV+XAscQlDhrCU5oCVAnRZeYW9hUgSIcCHxtBmrLGr6nVjisoewzhZntg+susmidACqxIP+IBy3YFuQy0u+V/y1Gd72gSZ91ykKsj2RoP+wDM4CUMiyr44ZvZpc5C0Mez+o6qWEZY5zxvyNe55d/K7kaocf6U+dPGd+TsZcHSEUDSnt6dKGcltCl/ZS33v6G3xOYz1ItJ0zvrnGI94n9cYbtF5S6hBxImK7wQugKwtxBbTwPRr7ha30Otfo8N1FPovcibTvTD5IBhuWLLVkTT3/Jf9nzm3rg+vM0BgaTWyblCl/h4c5aTYYrH6a2PKCOK5HrFjfPdQ==</Modulus><Exponent>AQAB</Exponent><P>6GQCcR1Hjnca4HuZua2T/GPCJSmA19VD24lZqBZ+bGZkytJwEUHjfHDDkVWc1+wmHa0bURE5Eai6af9BiH/v5DI0fM4m0z+E3d+g4GPzyi/0hl4cMXfklBW8kNy+Dytvmbme4DgZO28N6+9x4bc+MTDbMkqbAhqnElULfWHpzes=</P><Q>5ei7vbWxArdKsPlB4705jaGdTut1cBNVWyn9NiHsjluKpSLUqtPuolwujjYNvriiIWTBey8K8I6aZGWo9g3pA7DjK8Ib4RvfMlV3YQ6i/ywNqEN+26tKD39EDltz5aD4Oe4Qn2RSr7gB8oSyuXUchjeQOoAWJJGAiwxXuBBfoB8=</Q><DP>CNquoSKtdEcjdgQfkkyDw+0FG6deKlsMz9OG3/mjbXvlQTkNXgr1oOsm+GWbqTptJVpQHSGb3AliuOEp3QqK2FX1W//6yLe110JK/eGxCzYSigAR8OyRf/boDVjrwOY1xVSmMgLRK0uK6z9fRmtV6kfjQiJHj6f2T6N/4ZIWd2s=</DP><DQ>rMl6v5sbi3UBl3vdPzFpXb5GoZdoTXDaR4eJG/Pm+x5lVrKUrkZVJISvIIYTUnEkuIAmwVObnystcaLNlw7hPrrkIHDjzwzJc+Szsaf0bF5JbVo8rw9Ou9Lj7P5iXgPaSn9W0tPtKM7b984vHB6d72k25iB5g8Yum1INYvI7S/U=</DQ><InverseQ>V8xEMkZr8gSfb3QOrxYh0ob0IERREqAotRlmWG2W9s15IVmUXZ+IH4mtonOzll1liUPZqLvcScBEaxU+rtgl6uwQ0GHZosiozlVKRbbGHjPs4Nl955GSyxk7b5ev0iIubW3I+jIaYQw5XljgvKcK/bevRoSULY2P7/zM+xcSouY=</InverseQ><D>UeDFoOUMdjgDMSImTWmpYGzt2R3QhO7UKWI63LV3GZ43H0EpSJ43BkwLvDDJ0VCoOd7Upq9qh4WxKnKVQRve0uoyX3CxW72wvAaYIbvcGWYcwPf9WNgMah9+dgMYoMKTwNRp+faT4442lV0QHIlCe6kD0nfe8L6nnpClGRkqZSWhrVhPiWLjdG0L7MIl5ogzrKma6ebWh/ThSfdlwHP9enT++bfQvTD0gN778MsvvZrrjd/9TqfpzkuaXoYZX+ChT9hwBZYGD8r42nLZEpwSvUZMd7YM0pIpeSIQhUIsHjMcRDFIozGQkbcC14dzyxYNrxIZ35zi8Mvxs3A1xJVt1Q==</D></RSAKeyValue>";
        static string aeskeypath = @"C:\Users\boris\Desktop\Folderfortricks\aeskey.txt";
        static string aesvectorpath = @"C:\Users\boris\Desktop\Folderfortricks\aesvector.txt";
        static byte[] aeskey;
        static byte[] aesvector;

        static Cryptfunc()
        {
            aeskey = RSADecrypt(System.IO.File.ReadAllBytes(aeskeypath));
            aesvector = RSADecrypt(System.IO.File.ReadAllBytes(aesvectorpath));
        }

        public static void Signing(File f)
        {
            string filehash = Cryptfunc.GetHash(Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(f.pathtofile)));
            string logshash = Cryptfunc.GetHash(Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(f.pathtolog)));
            string strout = filehash + " -- " + logshash;
            System.IO.File.WriteAllBytes(f.pathtosign, Cryptfunc.RSAEncrypt(System.Text.Encoding.Default.GetBytes(strout)));
        }

        public static void Loging(File f)
        {
            byte[] logs;
            if (f.IsLogsExist())
            {
                logs = Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(f.pathtolog));
            }
            else
            {
                logs = null;
            }

            string laststr = f.state + " -- " + f.fromuser + " -- " + f.touser + " -- " + DateTime.Now + " -- " + f.note;
            if (logs != null)
            {
                string slogs = System.Text.Encoding.UTF8.GetString(logs);
                System.IO.File.WriteAllBytes(f.pathtolog, Cryptfunc.AESEncrypt(System.Text.Encoding.UTF8.GetBytes(slogs + "\r\n" + laststr)));
            }
            else
            {
                System.IO.File.WriteAllBytes(f.pathtolog, Cryptfunc.AESEncrypt(System.Text.Encoding.UTF8.GetBytes(laststr)));
            }
        }

        public static string GetHash(string input)
        {
            System.Security.Cryptography.SHA256 sha256Hash = System.Security.Cryptography.SHA256.Create();
            System.Security.Cryptography.HashAlgorithm hashAlgorithm = sha256Hash;
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static string GetHash(byte[] input)
        {
            System.Security.Cryptography.SHA256 sha256Hash = System.Security.Cryptography.SHA256.Create();
            System.Security.Cryptography.HashAlgorithm hashAlgorithm = sha256Hash;
            byte[] data = hashAlgorithm.ComputeHash(input);
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static bool IsHashEqual(string str, string hash)
        {
            if (GetHash(str)==hash)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static byte[] RSAEncrypt(byte[] input)
        {
            byte[] encrypted;
            using (var rsa = new System.Security.Cryptography.RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(publickey);
                encrypted = rsa.Encrypt(input, false);
            }
            return encrypted;
        }

        public static byte[] RSADecrypt(byte[] input)
        {
            byte[] decrypted;
            using (var rsa = new System.Security.Cryptography.RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(privatekey);
                decrypted = rsa.Decrypt(input, false);
            }
            return decrypted;
        }

        public static byte[] AESEncrypt(byte[] input)
        {
            using (var aes = new System.Security.Cryptography.AesCryptoServiceProvider())
            {
                aes.Key = aeskey;
                aes.IV = aesvector;
                using (var ms = new System.IO.MemoryStream())
                {
                    var cs = new System.Security.Cryptography.CryptoStream(ms, aes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
                    if (cs == null)
                        return null;
                    cs.Write(input, 0, input.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }

        public static byte[] AESDecrypt(byte[] input)
        {
            using (var aes = new System.Security.Cryptography.AesCryptoServiceProvider())
            {
                aes.Key = aeskey;
                aes.IV = aesvector;
                using (var ms = new System.IO.MemoryStream())
                {
                    var cs = new System.Security.Cryptography.CryptoStream(ms, aes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
                    if (cs == null)
                        return null;
                    cs.Write(input, 0, input.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }
    }
}