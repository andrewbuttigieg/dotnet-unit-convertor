using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_unit_convertor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var convertor = new Convertor();
             Console.WriteLine("Welcome to unit conversion! Type in a number and the unit to convert from and to and press Enter.");
             Console.WriteLine("Supported notation looks like this: 120fc.");
            var input = Console.ReadLine();

            var unitFrom = input[input.Length-2].ToString();
            var unitTo = input[input.Length-1].ToString();
            var toConvert = input.Substring(0, input.Length - 2);
            var toConvertDecimal = decimal.Parse(toConvert);

            Console.WriteLine(convertor.Convert(unitFrom, unitTo, toConvertDecimal));
        }
    }
}
