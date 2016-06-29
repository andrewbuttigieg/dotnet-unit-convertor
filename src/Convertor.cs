
using System;
using System.Collections.Generic;

namespace dotnet_unit_convertor
{
    public class Convertor
    {
        Convertor self;
        private Dictionary<Tuple<string, string>, Func<decimal, decimal>> conversionMap = 
                new Dictionary<Tuple<string, string>, Func<decimal, decimal>>();

        public Convertor(){
            self = this;
            conversionMap.Add(TupleFactory.Gen("f", "c"), (d) =>{ return (d - 32) * 5/9; } );
            conversionMap.Add(TupleFactory.Gen("c", "f"), (d) =>{ return (d * 9/5) + 32; } );
            conversionMap.Add(TupleFactory.Gen("k", "c"), (d) =>{ return d - 273.15m; } );
            conversionMap.Add(TupleFactory.Gen("c", "k"), (d) =>{ return d + 273.15m; } );
            conversionMap.Add(TupleFactory.Gen("k", "f"), (d) =>{ 
                var c = self.Convert("k", "c", d);
                return self.Convert("c", "f", c);
             } );
             conversionMap.Add(TupleFactory.Gen("f", "k"), (d) =>{ 
                var c = self.Convert("f", "c", d);
                return self.Convert("c", "k", c);
             });
            conversionMap.Add(TupleFactory.Gen("d", "r"), (d) =>{ return d * ((decimal)Math.PI / 180m); } );
            conversionMap.Add(TupleFactory.Gen("r", "d"), (d) =>{ return d * (180m / (decimal)Math.PI); } );
             
        }

        public decimal Convert(string from, string to, decimal unit)
        {
            var key = new Tuple<string, string>(from, to);
            if (conversionMap.ContainsKey(key))
                return  Math.Round(conversionMap[key](unit) * 100m) / 100m;
            else
                throw new Exception("Conversion not implemented");
        }
    }

}