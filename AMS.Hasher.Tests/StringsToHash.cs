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
            public static string SHA256 = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8";
            public static string SHA512 = "b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86";
            public static string ROT13 = "cnffjbeq";
        }

        public static class AllCharacters
        {
            // ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-=_+`~{}[]\|:;'"<>,./?
            public static string Input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-=_+`~{}[]\\|:;'\"<>,./?";

            public static string Base64 = "QUJDREVGR0hJSktMTU5PUFFSU1RVVldYWVphYmNkZWZnaGlqa2xtbm9wcXJzdHV2d3h5ejEyMzQ1Njc4OTAhQCMkJV4mKigpLT1fK2B+e31bXVx8OjsnIjw+LC4vPw==";
            public static string MD4 = "e3a4994b879d02a1dfcb0de7211c78ac";
            public static string MD5 = "7a8ab520aa9c9da79daf6a480e074c0e";
            public static string SHA1 = "1b59c7ad606790fdc3ea4234ae2ee4467d490c6b";
            public static string SHA256 = "a50d7ec257b4d4a137f939d8ed274a5314c37d019947069f9f5bcb24e4416a96";
            public static string SHA512 = "bd676eb73616128a4da792b012172a14018dc48536a3e3223847dd2add086ac4556dee7581ed355d3f2dd176d9bee887d471f577de7e5665ee4b3d0eab027998";
            public static string ROT13 = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm1234567890!@#$%^&*()-=_+`~{}[]\\|:;'\"<>,./?";
        }
    }
}