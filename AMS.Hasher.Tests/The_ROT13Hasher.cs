using AMS.Hasher.Hashers;
using AMS.Hasher.Tests;
using NUnit.Framework;

namespace The_ROT13Hasher
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
            var hasher = new ROT13();
            var hash = hasher.Hash(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.ROT13));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var hasher = new ROT13();
            var hash = hasher.Hash(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.ROT13));
        }
    }
}