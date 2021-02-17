using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        public abstract int Price();
    }

    public class CheesePizza : Pizza
    {
        public override int Price()
        {
            return 120;
        }
    }

    public class PepperoniPizza : Pizza
    {
        public override int Price()
        {
            return 100;
        }
    }

    public class SausagePizza : Pizza
    {
        public override int Price()
        {
            return 150;
        }
    }
}
