using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.Hasher
{
    public interface ITextHasher
    {
        string Base64(string input);
    }
}
