using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController varCntrl = new WeatherForecastController();
        [Fact]
        public void GetName()
        {
            var returnVal = varCntrl.Get(2);
            Assert.Equal("Soumitra", returnVal.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
