using fluffy_barnacle.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {

        [Fact]
        public void WeatherForecastControllerShouldReturnData()
        {

            var logger = Mock.Of<ILogger<WeatherForecastController>>();

            var controller = new WeatherForecastController(logger);

            var result = controller.Get();           

            Assert.NotNull(result.GetEnumerator());
        }

        [Fact]
        public void ValueControllerShouldReturnCorrectValue() {

            var logger = Mock.Of<ILogger<ValuesController>>();

            var controller = new ValuesController(logger);

            var result = controller.Get();

            Assert.Equal("Value 1", result.Value);
        }

        
    }
}
