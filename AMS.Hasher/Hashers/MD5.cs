namespace AMS.Hasher.Hashers
{
    public class MD5 : AbstractTextHasher<HashTypes.MD5>
    {
        protected override string GetHash(string input)
        {
            return GetHash(input, System.Security.Cryptography.MD5.Create());
        }
    }
}