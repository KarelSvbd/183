using System;
using System.Security.Cryptography;
using System.Text;

namespace hashsalt
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //string sSourceData;
            //byte[] tmpSource;
            //byte[] tmpHash;
            //Console.WriteLine("veuillez écrire un mot pour hash");
            //sSourceData = Console.ReadLine();
            ////Create a byte array from source data
            //tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);

            ////Compute hash based on source data
            //tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            //Console.Write("votre mot hasher: ");
            //Console.WriteLine(ByteArrayToString(tmpHash));
            //Console.ReadLine();
            #endregion
            Console.WriteLine("veuillez écrire un mot :) ");
            string input = Console.ReadLine();
            string saltedTruc = CreateSalt(20);
            string hashedTruc = GenerateHash(input, saltedTruc);
            Console.WriteLine(hashedTruc);
            if (AreEqual("salut", hashedTruc, saltedTruc))
            {
                Console.WriteLine("c pareil frro");
            } else
            {
                Console.WriteLine("c pas pareil frro");
            }

        }
        public static string CreateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public static string GenerateHash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static bool AreEqual(string plainTextInput, string hashedInput, string salt)
        {
            string newHashedPin = GenerateHash(plainTextInput, salt);
            return newHashedPin.Equals(hashedInput);
        }
        #region
        //static string ByteArrayToString(byte[] arrInput)
        //{
        //    int i;
        //    StringBuilder sOutput = new StringBuilder(arrInput.Length);
        //    for (i = 0; i < arrInput.Length - 1; i++)
        //    {
        //        sOutput.Append(arrInput[i].ToString("X2"));
        //    }
        //    return sOutput.ToString();
        //}
        #endregion
    }
}