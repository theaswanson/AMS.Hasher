using AMS.Hasher.Hashers;
using AMS.Hasher.HashTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.Hasher.Tests
{
    public class FakeTextHasher<T> : AbstractTextHasher<T> where T : IHashType
    {
        protected override string GetHash(string input)
        {
            return "fake-hash";
        }
    }
}