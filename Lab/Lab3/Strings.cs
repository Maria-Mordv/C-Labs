using Lab3.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public static class Strings
    {
        public static void Comparrison()
        {
            string FirstLine;
            string SecondLine;

            Console.WriteLine("\nEnter the first string:\n");
            FirstLine = IOUtils.ReadValue(null);

            Console.WriteLine("\nEnter the second string:\n");
            SecondLine = IOUtils.ReadValue(null);

            Console.WriteLine("\nChecks:\n");

            Checks.StringsAreEqual(FirstLine, SecondLine);
            Checks.StringsAreEqualCleanned(FirstLine, SecondLine);
            Checks.StringsAreEqualReverce(FirstLine, SecondLine);
            Checks.IsPhoneIpEmail(FirstLine, SecondLine);
        }
    }
}
