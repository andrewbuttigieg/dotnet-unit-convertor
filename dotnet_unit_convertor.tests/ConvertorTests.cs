using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace dotnet_unit_convertor
{
    public class ConvertorTests
    {
        [Fact]
        public void Convertor_100Fran_38Celcius()
        {
            var convertor = new Convertor();
            var celcius =  convertor.Convert("f", "c", 100);

            Assert.Equal(celcius, 38m);
        }
    }
}
