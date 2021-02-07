using AMS.Hasher.Hashers;
using AMS.Hasher.Tests;
using NUnit.Framework;

namespace The_MD4Hasher
{
    [TestFixture]
    public class HashTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_string_password_returns_correct_hash()
        {
            var hasher = new MD4();
            var hash = hasher.Hash(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.MD4));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var hasher = new MD4();
            var hash = hasher.Hash(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.MD4));
        }
    }
}