using System;
using Xunit;
using IoT.Automation.API.Controllers;
using IoT.Automation.Data.Services;

namespace xUnitTestProject
{
    public class APITest
    {
        [Fact]
        public void Test1()
        {
            var controller = new TemperatureController(new DbService());
            var result = controller.AddTemperature(23d, 10d, 45d);

        }
    }
}
