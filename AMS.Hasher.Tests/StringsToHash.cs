using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.Hasher.Tests
{
    public static class StringsToHash
    {
        public static class Password
        {
            public static string Input = "password";
            public static string Base64 = "cGFzc3dvcmQ=";
        }

        public static class AllCharacters
        {
            // ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-=_+`~{}[]\|:;'"<>,./?
            public static string Input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-=_+`~{}[]\\|:;'\"<>,./?";
            public static string Base64 = "QUJDREVGR0hJSktMTU5PUFFSU1RVVldYWVphYmNkZWZnaGlqa2xtbm9wcXJzdHV2d3h5ejEyMzQ1Njc4OTAhQCMkJV4mKigpLT1fK2B+e31bXVx8OjsnIjw+LC4vPw==";
        }
    }
}
