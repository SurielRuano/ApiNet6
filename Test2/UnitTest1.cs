using ApiNetCoreDevops;

namespace Test2
{
    [TestClass]
    public class UnitTest1
    {
        public int Temp { get; set; } = 10;

        public void TestMethod1()
        {
            //Arrange
            var obj = new WeatherForecast();
            //Act

            obj.TemperatureC = Temp;
            //Assert
            Assert.AreEqual(10, obj.TemperatureC);
        }
        

   

        [TestMethod]

        public void Test2()
        {
            //Arrange
            var obj = new WeatherForecast();
            //Act

            obj.TemperatureC = Temp;
            //Assert
            Assert.AreEqual(10, obj.TemperatureC);
        }
    }
}