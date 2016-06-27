using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.SimpleFactory.Pizza
{
    public class PizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;

            }

            return pizza;
        }
    }
}
