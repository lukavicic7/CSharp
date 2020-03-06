using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba1{
    class Zad2
    {
        static void Main8(string[] args)
        {
            long number1 = long.MaxValue;
            try{
                // The following line raises an exception because it is checked.
                int number2 = checked(Convert.ToInt32(number1));
                Console.WriteLine(number2);
            }
            catch (System.OverflowException e)
            {
                // The following line displays information about the error.
                Console.WriteLine("Checked and caught:  " + e.ToString());
            }
        }
    }
}
