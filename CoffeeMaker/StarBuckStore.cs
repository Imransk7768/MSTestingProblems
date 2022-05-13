using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarBuckStore
    {
        public readonly IMakeACoffee services;
        public StarBuckStore(IMakeACoffee coffee)
        {
            this.services = coffee;
        }
        public string OrderCoffee(int sugarPerSpoon, int coffeePack)
        {
            if (services.CheckIngidientAvailability())
            {
                return services.CoffeeMaking(sugarPerSpoon, coffeePack);
            }
            return "Sorry! Coffee Is Not Available";
        }
    }
}
