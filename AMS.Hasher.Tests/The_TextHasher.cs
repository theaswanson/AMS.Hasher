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

    public class MD4
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
                textHasher.MD4(null);
            });
            Assert.That(exception.Message, Is.EqualTo("Input cannot be null."));
        }

        [Test]
        public void Given_string_password_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.MD4(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.MD4));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.MD4(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.MD4));
        }
    }

    public class MD5
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
                textHasher.MD5(null);
            });
            Assert.That(exception.Message, Is.EqualTo("Input cannot be null."));
        }

        [Test]
        public void Given_string_password_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.MD5(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.MD5));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.MD5(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.MD5));
        }
    }

    public class SHA1
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
                textHasher.SHA1(null);
            });
            Assert.That(exception.Message, Is.EqualTo("Input cannot be null."));
        }

        [Test]
        public void Given_string_password_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.SHA1(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.SHA1));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.SHA1(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.SHA1));
        }
    }

    public class SHA256
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
                textHasher.SHA256(null);
            });
            Assert.That(exception.Message, Is.EqualTo("Input cannot be null."));
        }

        [Test]
        public void Given_string_password_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.SHA256(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.SHA256));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.SHA256(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.SHA256));
        }
    }

    public class SHA512
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
                textHasher.SHA512(null);
            });
            Assert.That(exception.Message, Is.EqualTo("Input cannot be null."));
        }

        [Test]
        public void Given_string_password_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.SHA512(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.SHA512));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.SHA512(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.SHA512));
        }
    }

    public class ROT13
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
                textHasher.ROT13(null);
            });
            Assert.That(exception.Message, Is.EqualTo("Input cannot be null."));
        }

        [Test]
        public void Given_string_password_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.ROT13(StringsToHash.Password.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.Password.ROT13));
        }

        [Test]
        public void Given_string_with_all_characters_returns_correct_hash()
        {
            var textHasher = new TextHasher();
            var hash = textHasher.ROT13(StringsToHash.AllCharacters.Input);
            Assert.That(hash, Is.EqualTo(StringsToHash.AllCharacters.ROT13));
        }
    }
}