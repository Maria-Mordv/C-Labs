using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public static class IOUtils
    {
        public static int SafeReadInteger(string message)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine(message);
                }
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue))
                {
                    return iValue;
                }
                Console.WriteLine("\nERROR: Incorrect format. Enter Integer value... ");
            }
        }

        public static DateTime SafeReadDate(string message)
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Console.WriteLine(message);
                }
                string sValue = Console.ReadLine();
                DateTime date;
                if (DateTime.TryParseExact(sValue, "dd.mm.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
                {
                    return date;
                }
                Console.WriteLine("ERROR! Input date in correct format! dd.mm.yyyy");
            }
        }

        public static string ReadValue(string message)
        {
            string sValue = Console.ReadLine();
            return sValue;
        }
    }
}
