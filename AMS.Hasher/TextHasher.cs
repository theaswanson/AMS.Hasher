using System;
using System.Collections.Generic;
using System.Text;

namespace AMS.Hasher
{
    public class TextHasher : ITextHasher
    {
        public string Base64(string input)
        {
            CheckInput(input);
            var bytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes);
        }

        private void CheckInput(string input)
        {
            if (input is null)
            {
                throw new ArgumentException("Input cannot be null.");
            }
        }
    }
}
