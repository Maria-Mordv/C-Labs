using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public static class Calc
    {
        public static double getResult()
        {
            while (true)
            {
                Console.WriteLine("\nEnter integer X:");
                int iX = -1;
                while (iX < 0)
                {
                    iX = IOUtils.SafeReadInteger(null);
                    if (iX < 0)
                    {
                        Console.WriteLine("\nERROR: Enter Integer value of X, greater than or equal to 0");
                    }
                }

                Console.WriteLine("\nEnter integer Z:");
                int iZ = 0;
                while (iZ == 0)
                {
                    iZ = IOUtils.SafeReadInteger(null);
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
