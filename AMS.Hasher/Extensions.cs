using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AMS.Hasher
{
    public static class Extensions
    {
        public static string GetHash(this string input, HashAlgorithm algorithm)
        {
            var hash = algorithm.ComputeHash(input.ToBytes());
            return hash.ToHashString();
        }

        public static byte[] ToBytes(this string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }

        public static string ToHashString(this byte[] bytes)
        {
            var stringBuilder = new StringBuilder();
            foreach (var aByte in bytes)
            {
                stringBuilder.Append(aByte.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}