using AMS.Hasher;
using AMS.Hasher.Tests;
using FakeItEasy;
using NUnit.Framework;
using System;

namespace The_TextHasher
{
    public class Base64
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_null_throws_exception()
        {
            var textHasher = new TextHasher();
            var exception = Assert.Throws<ArgumentException>(delegate
            {
                textHasher.Base64(null);
            });
            Assert.That(exception.Message, Is.EqualTo("Input cannot be null."));
        }

        [Test]
        public void Given_string_password_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.Base64(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.Base64));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.Base64(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.Base64));
        }
    }
}