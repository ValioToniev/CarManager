
namespace CarManager.Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldRefuelNormally()
        {
            Car car = new Car("Vw", "Golf", 2, 100);
            car.Refuel(10);
            double expectedFuelAmount = 10;
            double actualFuelAmount = car.FuelAmount;
            Assert.AreEqual(expectedFuelAmount, actualFuelAmount); 
        }
        
        
        [Test]  
        public void ShouldRefuelUntillTotalFuelCapacity()
        {
            Car car=new Car("Vw", "Golf", 2, 100);
            car.Refuel(150);
            double expectedFuelAmount=100;
            double actualFuelAmount=car.FuelAmount;
            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

    }
}