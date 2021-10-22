using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1MordvincevaSBS_002var8
{
    class Program
    {
        public static int SafeReadI { get; private set; }

        static void Main(string[] args)
        {
            while (true)
            {
                switch (getMenuItem())
                {
                    case 0:
                        Console.WriteLine("\nExit...");
                        return;
                    case 1:
                        Console.WriteLine("\nHello World!");
                        break;
                    case 2:
                        Console.WriteLine("\nYou chose to solve sqrt(X)-6/Z");

                        double Result = getResult();
                        Console.WriteLine("\nResult: {0:0.###}", Result);
                        break;

                    default:
                        Console.WriteLine("\nMenu item not found.");
                        break;


                }
            }
        }

        private static int getMenuItem()
        {
            Console.WriteLine("\nMain Menu: ");
            Console.WriteLine("[0] Exit ");
            Console.WriteLine("[1] Hello World! ");
            Console.WriteLine("[2] Calc: sqrt(X)-6/Z ");
            int iMenu = SafeReadInteger(null);
            return iMenu;
        }

        private static int SafeReadInteger(string message)
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

        private static double getResult()
        {
            while (true)
            {
                Console.WriteLine("\nEnter integer X:");
                int iX = -1;
                while (iX < 0)
                {
                    iX = SafeReadInteger(null);
                    if (iX < 0)
                    {
                        Console.WriteLine("\nERROR: Enter Integer value of X, greater than or equal to 0");
                    }
                }

                Console.WriteLine("\nEnter integer Z:");
                int iZ = 0;
                while (iZ == 0)
                {
                    iZ = SafeReadInteger(null);
                    if (iZ == 0)
                    {
                        Console.WriteLine("\nERROR: Enter Integer value of Z, not equal to 0");
                    }
                } 

                double Result = Math.Sqrt(iX) - (6 / iZ);

                return Result;
            }
        }
    }
}