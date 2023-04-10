using ApiNetCoreDevops;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var obj = new WeatherForecast();
            //Act

            obj.TemperatureC = 10;
            //Assert
            Assert.AreEqual(0,obj.TemperatureC);
        }

        [Test]
        public void Test2()
        {
            //Arrange
            var obj = new WeatherForecast();
            //Act

            obj.TemperatureC = 10;
            //Assert
            Assert.AreEqual(10,obj.TemperatureC);
        }
    }
}