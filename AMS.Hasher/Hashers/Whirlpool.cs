namespace AMS.Hasher.Hashers
{
    public class Whirlpool : AbstractTextHasher<HashTypes.Whirlpool>
    {
        protected override string GetHash(string input)
        {
            var digest = new Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest();
            digest.Reset();
            var inputBytes = ToBytes(input);
            digest.BlockUpdate(inputBytes, 0, inputBytes.Length);
            var hashBytes = new byte[digest.GetDigestSize()];
            digest.DoFinal(hashBytes, 0);
            return ToHashString(hashBytes);
        }
    }
}