using AMS.Hasher.Hashers;
using AMS.Hasher.Tests;
using NUnit.Framework;

namespace The_SHA256Hasher
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
            var hasher = new SHA256();
            var hash = hasher.Hash(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.SHA256));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var hasher = new SHA256();
            var hash = hasher.Hash(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.SHA256));
        }
    }
}