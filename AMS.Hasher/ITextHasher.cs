using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.Hasher
{
    public interface ITextHasher
    {
        string Base64(string input);

        string MD4(string input);

        string MD5(string input);

        string SHA1(string input);

        string SHA256(string input);
    }
}