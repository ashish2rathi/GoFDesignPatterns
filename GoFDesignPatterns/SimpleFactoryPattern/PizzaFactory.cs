using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public static class PizzaFactory
    {
        public static IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.NeapolitanPizza:
                    return new NeapolitanPizza();
                case PizzaType.ChicagoPizza:
                    return new ChicagoPizza();
                case PizzaType.NewYorkStylePizza:
                    return new NewYorkStylePizza();
                default:
                    return null;
            }
        }
    }
}