using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.MenuItems
{
    public class MenuItemCalc : MenuItemCore
    {
        public override string Title { get { return "Calc: sqrt(X)-6/Z"; } }

        public override void Execute()
        {
            Console.WriteLine("\nYou chose to solve sqrt(X)-6/Z");
            double Result = Calc.getResult();
            Console.WriteLine("\nResult: {0:0.000}", Result);
        }
    }
}
