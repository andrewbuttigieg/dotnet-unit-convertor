using System;

namespace dotnet_unit_convertor
{
    public class TupleFactory{
        public static Tuple<string, string> Gen(string from, string to){
            return new Tuple<string, string>(from, to);
        }
    }
}