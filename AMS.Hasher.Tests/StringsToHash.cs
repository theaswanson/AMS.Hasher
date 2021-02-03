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
            public static string MD4 = "8a9d093f14f8701df17732b2bb182c74";
            public static string MD5 = "5f4dcc3b5aa765d61d8327deb882cf99";
            public static string SHA1 = "5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8";
        }

        public static class AllCharacters
        {
            // ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-=_+`~{}[]\|:;'"<>,./?
            public static string Input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-=_+`~{}[]\\|:;'\"<>,./?";

            public static string Base64 = "QUJDREVGR0hJSktMTU5PUFFSU1RVVldYWVphYmNkZWZnaGlqa2xtbm9wcXJzdHV2d3h5ejEyMzQ1Njc4OTAhQCMkJV4mKigpLT1fK2B+e31bXVx8OjsnIjw+LC4vPw==";
            public static string MD4 = "e3a4994b879d02a1dfcb0de7211c78ac";
            public static string MD5 = "7a8ab520aa9c9da79daf6a480e074c0e";
            public static string SHA1 = "1b59c7ad606790fdc3ea4234ae2ee4467d490c6b";
        }
    }
}