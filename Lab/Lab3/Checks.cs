using Lab3.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public static class Checks
    {
        public static void StringsAreEqual(string St1, string St2)
        {
            try
            {
                Validation.AreEqual(St1, St2);
                Console.WriteLine("Strings are equal.\n");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void StringsAreEqualCleanned(string St1, string St2)
        {
            try
            {
                Validation.AreEqualCleanned(St1, St2);
                Console.WriteLine("Cleaned strings are equal.\n");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void StringsAreEqualReverce(string St1, string St2)
        {
            try
            {
                Validation.AreEqualAfterReverce(St1, St2);
                Console.WriteLine("First string is reversed second string.\n");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void StringIsMail(string St1, int Number)
        {
            try
            {
                Validation.IsMail(St1, Number);                
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void StringIsPhoneNumber(string St1, int Number)
        {
            try
            {
                Validation.IsNumber(St1, Number);                
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void StringIsIP(string St1, int Number)
        {
            try
            {
                Validation.IsIP(St1, Number);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void IsPhoneIpEmail(string a, string b)
        {
            StringIsMail(a, 1);
            StringIsPhoneNumber(a, 1);
            StringIsIP(a, 1);
            StringIsMail(b, 2);
            StringIsPhoneNumber(b, 2);
            StringIsIP(b, 2);
        }
    }
}
