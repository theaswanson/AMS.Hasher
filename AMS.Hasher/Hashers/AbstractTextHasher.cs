using AMS.Hasher.HashTypes;
using System;
using System.Security.Cryptography;
using System.Text;

namespace AMS.Hasher.Hashers
{
    public abstract class AbstractTextHasher<T> : ITextHasher<T> where T : IHashType
    {
        public string Hash(string input)
        {
            CheckInput(input);
            return GetHash(input);
        }

        protected abstract string GetHash(string input);

        protected byte[] ToBytes(string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }

        protected string GetHash(string input, HashAlgorithm algorithm)
        {
            var hash = algorithm.ComputeHash(ToBytes(input));
            return ToHashString(hash);
        }

        protected string ToHashString(byte[] bytes)
        {
            var stringBuilder = new StringBuilder();
            foreach (var aByte in bytes)
            {
                stringBuilder.Append(aByte.ToString("x2"));
            }
            return stringBuilder.ToString();
        }

        private void CheckInput(string input)
        {
            if (input is null)
            {
                throw new ArgumentException("Input cannot be null.");
            }
        }
    }
}