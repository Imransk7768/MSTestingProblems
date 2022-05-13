using CoffeeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace StarBucksTest
{
    [TestClass]
    public class StarBucksUnitTesting
    {

        [TestMethod]
        public void OrderCoffeeFake_InStarBucks_ShouldReturnReceiveMessage()
        {
            StarBuckStore store = new StarBuckStore(new FakeStarBucks());
            string actual = store.OrderCoffee(2, 4);
            Assert.AreEqual(actual, "Your Order Is Received");
        }
        [TestMethod]
        public void OrderCoffeeFakeMoq_InStarBucks_ShouldReturnReceiveMessage()
        {
            var moqSevice = new Mock<IMakeACoffee>();
            moqSevice.Setup(x => x.CheckIngidientAvailability()).Returns(true);
            moqSevice.Setup(x => x.CoffeeMaking(2, 3)).Returns("Your Coffee Is Received");
            StarBuckStore store = new StarBuckStore(moqSevice.Object);
            string actual = store.OrderCoffee(2, 3);
            Assert.AreEqual(actual, "Your Order Is Received");
        }
        [TestMethod]
        public void OrderCoffeeStub_InStarBucks_ShouldReturnReceivesMessage()
        {
            StarBuckStore store = new StarBuckStore(new StubStarBucks());
            string actual = store.OrderCoffee(3, 5);
            Assert.AreEqual(actual, "Your Order Is Received");
        }
    }
}
