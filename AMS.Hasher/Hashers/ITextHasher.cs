using AMS.Hasher.HashTypes;

namespace AMS.Hasher.Hashers
{
    public interface ITextHasher<T> where T : IHashType
    {
        string Hash(string input);
    }
}