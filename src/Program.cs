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
            Console.WriteLine(convertor.Convert("f", "c", 100));
            Console.WriteLine(convertor.Convert("k", "c", 0));
            Console.WriteLine(convertor.Convert("k", "f", 0));
            Console.WriteLine(convertor.Convert("f", "k", 0));
            Console.Read();
        }
    }
}
