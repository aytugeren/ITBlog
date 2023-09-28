using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ITBlog.Extension.AuthenticationExtensions
{
    public class HashingAlgorithm
    {
        private readonly string _saltPassword;

        public HashingAlgorithm(string saltPassword)
        {
            this._saltPassword = saltPassword;
        }

        public string GenerateSaltedHash(string plainText)
        {
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] plainTextByteArr = Encoding.ASCII.GetBytes(plainText);
            byte[] saltPasswordByteArr = Encoding.ASCII.GetBytes(_saltPassword);

            byte[] plainTextWithSaltBytes = new byte[plainTextByteArr.Length + saltPasswordByteArr.Length];

            for (int i = 0; i < plainTextByteArr.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainTextByteArr[i];
            }

            for (int i = 0; i < saltPasswordByteArr.Length; i++)
            {
                plainTextWithSaltBytes[plainTextByteArr.Length + i] = saltPasswordByteArr[i];
            }

            var byteArr = algorithm.ComputeHash(plainTextByteArr);
            return BitConverter.ToString(byteArr).Replace("-", string.Empty);
        }

        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
