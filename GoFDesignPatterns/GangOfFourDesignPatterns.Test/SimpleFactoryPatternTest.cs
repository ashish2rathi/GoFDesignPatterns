using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleFactoryPattern;

namespace GangOfFourDesignPatterns.Test
{
    [TestClass]
    public class SimpleFactoryPatternTest
    {
        [TestMethod]
        public void ChicagoPizza()
        {
            IPizza pizza = PizzaFactory.CreatePizza(PizzaType.ChicagoPizza);
            int price = pizza.price();
            Assert.AreEqual(price, 120);
        }

        [TestMethod]
        public void NeapolitanPizza()
        {
            IPizza pizza = PizzaFactory.CreatePizza(PizzaType.NeapolitanPizza);
            int price = pizza.price();
            Assert.AreEqual(price, 100);
        }

        [TestMethod]
        public void NewYorkStylePizza()
        {
            IPizza pizza = PizzaFactory.CreatePizza(PizzaType.NewYorkStylePizza);
            int price = pizza.price();
            Assert.AreEqual(price, 150);
        }
    }
}
