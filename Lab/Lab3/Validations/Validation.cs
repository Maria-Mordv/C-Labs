using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3.Validations
{
    public class Validation
    {
        public static void AreEqual(string St1, string St2)
        {
            if (St1 != St2)
            {
                throw new ValidationException(string.Format("Strings are not equal.\n"));
            }
        }

        public static void AreEqualCleanned(string St1, string St2)
        {
            St1 = St1.Trim();
            St2 = St2.Trim();
            St1 = St1.ToLower();
            St2 = St2.ToLower();

            while (St1.Contains("  ") || St2.Contains("  "))
            {
                St1 = St1.Replace("  ", " ");
                St2 = St2.Replace("  ", " ");
            }

            if (St1 != St2)
            {
                throw new ValidationException(string.Format("Cleaned strings are not equal.\n"));
            }
        }

        public static void AreEqualAfterReverce(string St1, string St2)
        {
            char[] arrSt2 = St2.ToCharArray();
            Array.Reverse(arrSt2);
            St2 = new string(arrSt2);
            if (St1 != St2)
            {
                throw new ValidationException(string.Format("First string is not reversed second string.\n"));
            }
        }

        public static void IsMail(string St, int Number)
        {
            string pattern = "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+";
            Match isMatch = Regex.Match(St.ToLower(), pattern, RegexOptions.IgnoreCase);
            if (isMatch.Success)
            {
                Console.WriteLine("String {0} contains an email.\n", Number);
            }
            else
            {
                throw new ValidationException(string.Format("String {0} is not an email.\n", Number));
            }
        }
        public static void IsNumber(string St, int Number)
        {
            string pattern = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
            Match isMatch = Regex.Match(St.ToLower(), pattern, RegexOptions.IgnoreCase);
            if (isMatch.Success)
            {
                Console.WriteLine("String {0} contains a number.\n", Number);
            }
            else
            {
                throw new ValidationException(string.Format("String {0} is not a number.\n", Number));
            }
        }
        public static void IsIP(string St, int Number)
        {
            string pattern = "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
            Match isMatch = Regex.Match(St.ToLower(), pattern, RegexOptions.IgnoreCase);
            if (isMatch.Success)
            {
                Console.WriteLine("String {0} contains an IP.\n", Number);
            }
            else
            {
                throw new ValidationException(string.Format("String {0} is not an IP.\n", Number));
            }
        }
    }
}
