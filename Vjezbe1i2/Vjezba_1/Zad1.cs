using System;
using System.Globalization;
using System.IO;

namespace Vjezba1{
    class Zad1{
        static void Main1(string[] args){
            try {
                var number1 = Console.ReadLine();
                var number2 = Console.ReadLine();
                //int number2 = Convert.ToInt32(Console.ReadLine());

                int division_int = Convert.ToInt32(number1) / Convert.ToInt32(number2);
                Console.WriteLine("Currency: " + division_int.ToString("C", CultureInfo.CurrentCulture));
                Console.WriteLine("Integer: "+ division_int);
                Console.WriteLine("Scientific: " + string.Format("{0:#.##E+0}", division_int));
                Console.WriteLine("Fixed-point: " + division_int.ToString("F", CultureInfo.InvariantCulture));
                Console.WriteLine("General :" + division_int.ToString("G", CultureInfo.InvariantCulture));
                Console.WriteLine("Number :" + division_int.ToString("N", CultureInfo.InvariantCulture));
                Console.WriteLine("Hexadecimal :" + division_int.ToString("X", CultureInfo.InvariantCulture));

            }
            catch (DivideByZeroException d){
                Console.WriteLine(d.Message);
            }
            catch (ArgumentNullException n)
            {
                Console.WriteLine(n.Message);
            }
            catch (FormatException f) {
                Console.WriteLine(f.Message);
            }
            catch (OverflowException o){
                Console.WriteLine(o.Message);
            }
            catch (IOException s)
            {
                Console.WriteLine(s.Message);
            }
            catch (OutOfMemoryException m)
            {
                Console.WriteLine(m.Message);
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a.Message);
            }
        }
    }
}
