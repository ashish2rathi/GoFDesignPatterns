using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class BasePizzaFactory
    {
        public abstract Pizza createPizza(PizzaType type);
    }

    public class PizzaFactory : BasePizzaFactory
    {
        public override Pizza createPizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
                case PizzaType.Sausage:
                    return new SausagePizza();
                default:
                    return null;
            }
        }
    }

    public class NeapolitanPizzaFactory : BasePizzaFactory
    {
        public override Pizza createPizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
                default:
                    return null;
            }
        }
    }

    public class ChicagoPizzaFactory : BasePizzaFactory
    {
        public override Pizza createPizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();
                case PizzaType.Sausage:
                    return new SausagePizza();
                default:
                    return null;
            }
        }
    }

    public class NewYorkPizzaFactory : BasePizzaFactory
    {
        public override Pizza createPizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
                case PizzaType.Sausage:
                    return new SausagePizza();
                default:
                    return null;
            }
        }
    }
}
