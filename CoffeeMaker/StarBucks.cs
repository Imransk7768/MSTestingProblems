
namespace CoffeeMaker
{
    public class StarBucks : IMakeACoffee
    {
        public bool CheckIngidientAvailability()
        {
            return true;
        }
        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarBucks : IMakeACoffee
    {
        public bool CheckIngidientAvailability()
        {
            return true;
        }
        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            return "Your Order is Received";
        }
    }
    public class FakeStarBucks : IMakeACoffee
    {
        public bool CheckIngidientAvailability()
        {
            return true;
        }
        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            return "Your Order is Received";
        }
    }
}