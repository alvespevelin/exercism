using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace exercism.tasks
{
    internal class Identifier
    {
        public static string CleanMy(string identifier)
        {
            identifier = identifier.Replace(' ', '_');
            string result = identifier;
            for (int ctr = 0; ctr < identifier.Length; ctr++)
            {
                if (Char.IsControl(identifier, ctr))
                    result = result.Replace(identifier[ctr].ToString(), "CTRL");
                else if (identifier[ctr] == '-')
                    result = result.Replace(result[ctr + 1], Char.ToUpper(result[ctr + 1]));
                else if(!Char.IsLetter(identifier[ctr]) && result[ctr] != '_')
                    result = result.Replace(result[ctr], ' ');
                if(identifier[ctr] >= 0x03B1 && identifier[ctr] <= 0x03C9)
                    result = result.Replace(result[ctr], ' ');
            }

            return result.Replace("-", "").Replace(" ", "");
        }

        public static string CleanGPT(string identifier)
        {
            if (string.IsNullOrEmpty(identifier)) return string.Empty;

            StringBuilder sb = new StringBuilder();
            identifier = identifier.Replace(' ', '_');

            for (int i = 0; i < identifier.Length; i++)
            {
                char c = identifier[i];

                // Replace control characters with "CTRL"
                if (char.IsControl(c))
                {
                    sb.Append("CTRL");
                    continue;
                }

                // Skip Greek lowercase letters
                if (c >= 0x03B1 && c <= 0x03C9)
                    continue;

                // Handle dash-case to camelCase
                if (c == '-' && i + 1 < identifier.Length && char.IsLetter(identifier[i + 1]))
                {
                    sb.Append(char.ToUpper(identifier[++i]));
                    continue;
                }

                // Allow letters and underscores only
                if (char.IsLetter(c) || c == '_')
                    sb.Append(c);
            }

            return sb.ToString();
        }
    }
}