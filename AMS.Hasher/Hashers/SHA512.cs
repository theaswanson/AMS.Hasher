namespace AMS.Hasher.Hashers
{
    public class SHA512 : AbstractTextHasher<HashTypes.SHA512>
    {
        protected override string GetHash(string input)
        {
            return GetHash(input, System.Security.Cryptography.SHA512.Create());
        }
    }
}