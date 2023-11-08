using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3ps1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Using TryParse for converting a string to an integer
            //Console.WriteLine("enter the number to convert to an integer");
            //string numberString = Console.ReadLine();
            //if (int.TryParse(numberString, out number))
            //{
            //    Console.WriteLine("Conversion successful. Integer value: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Conversion failed. Invalid input for Integer.");
            //}

            //// Using Convert to convert a string to a double
            //Console.WriteLine("enter the number to convert to an double");
            //string doubleString= Console.ReadLine();
            //try
            //{
            //    double convertedDouble = Convert.ToDouble(doubleString);
            //    Console.WriteLine("Conversion successful. Double value: " + convertedDouble);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Conversion failed. Invalid input for Double.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Conversion failed. Input is too large for Double.");
            //}

            // Using Parse to convert a string to a decimal
            Console.WriteLine("enter the number to convert to an decimal");
            string decimalString = Console.ReadLine();
            try
            {
                decimal convertedDecimal = decimal.Parse(decimalString);
                Console.WriteLine("Conversion successful. Decimal value: " + convertedDecimal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion failed. Invalid input for Decimal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Conversion failed. Input is too large for Decimal.");
            }
            Console.ReadKey();




        }
    }
    }
 

