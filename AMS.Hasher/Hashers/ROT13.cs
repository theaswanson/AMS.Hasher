using System.Text;
using System.Text.RegularExpressions;

namespace AMS.Hasher.Hashers
{
    public class ROT13 : AbstractTextHasher<HashTypes.ROT13>
    {
        protected override string GetHash(string input)
        {
            var result = new StringBuilder();
            var regex = new Regex("[A-Za-z]");

            foreach (char character in input)
            {
                if (regex.IsMatch(character.ToString()))
                {
                    int charCode = ((character & 223) - 52) % 26 + (character & 32) + 65;
                    result.Append((char)charCode);
                }
                else
                {
                    result.Append(character);
                }
            }
            return result.ToString();
        }
    }
}