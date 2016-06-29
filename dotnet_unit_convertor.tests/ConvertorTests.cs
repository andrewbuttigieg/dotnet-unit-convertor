using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet_unit_convertor
{
    [TestClass]
    public class ConvertorTests
    {
        [TestMethod]
        public void Convertor_100Fran_37_78Celcius()
        {
            var convertor = new Convertor();
            var celcius =  convertor.Convert("f", "c", 100);

            Assert.AreEqual(celcius, 37.78m);
        }

        [TestMethod]
        public void Convertor_37_78Celcius_100Fran()
        {
            var convertor = new Convertor();
            var celcius =  convertor.Convert("c", "f", 37.78m);

            Assert.AreEqual(celcius, 100m);
        }
    }
}
