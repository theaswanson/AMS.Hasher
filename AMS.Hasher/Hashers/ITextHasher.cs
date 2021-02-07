using AMS.Hasher.HashTypes;

namespace AMS.Hasher.Hashers
{
    public interface ITextHasher
    {
        string Hash(string input);
    }

    public interface ITextHasher<T> : ITextHasher where T : IHashType
    {
    }
}