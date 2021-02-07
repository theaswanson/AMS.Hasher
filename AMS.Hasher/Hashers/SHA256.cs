namespace AMS.Hasher.Hashers
{
    public class SHA256 : AbstractTextHasher<HashTypes.SHA256>
    {
        protected override string GetHash(string input)
        {
            return GetHash(input, System.Security.Cryptography.SHA256.Create());
        }
    }
}