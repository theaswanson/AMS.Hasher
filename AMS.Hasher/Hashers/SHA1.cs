namespace AMS.Hasher.Hashers
{
    public class SHA1 : AbstractTextHasher<HashTypes.SHA1>
    {
        protected override string GetHash(string input)
        {
            return GetHash(input, System.Security.Cryptography.SHA1.Create());
        }
    }
}