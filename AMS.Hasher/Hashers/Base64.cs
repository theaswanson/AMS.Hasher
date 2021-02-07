using System;

namespace AMS.Hasher.Hashers
{
    public class Base64 : AbstractTextHasher<HashTypes.Base64>
    {
        protected override string GetHash(string input)
        {
            return Convert.ToBase64String(ToBytes(input));
        }
    }
}