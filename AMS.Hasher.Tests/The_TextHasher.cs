using AMS.Hasher;
using AMS.Hasher.Tests;
using FakeItEasy;
using NUnit.Framework;
using System;

namespace The_TextHasher
{
    [TestFixture]
    public class Prerequisites
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_null_input_throws_exception()
        {
            var hasher = new FakeTextHasher<AMS.Hasher.HashTypes.Base64>();
            var exception = Assert.Throws<ArgumentException>(delegate
            {
                hasher.Hash(null);
            });
            Assert.That(exception.Message, Is.EqualTo("Input cannot be null."));
        }
    }
}