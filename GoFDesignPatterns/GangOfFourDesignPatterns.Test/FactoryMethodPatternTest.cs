using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GangOfFourDesignPatterns.Test
{
    [TestClass]
    public class FactoryMethodPatternTest
    {
        private const int _cheesPizzaPrice = 120;
        private const int _pepperoniPizzaPrice = 100;
        private const int _sausagePizzaPrice = 150;

        [TestMethod]
        public void PizzaFactory()
        {
            var factory = new PizzaFactory();

            var cheesePizza = factory.createPizza(PizzaType.Cheese);
            Assert.AreEqual(cheesePizza.Price(), _cheesPizzaPrice);

            var pepperoniPizza = factory.createPizza(PizzaType.Pepperoni);
            Assert.AreEqual(pepperoniPizza.Price(), _pepperoniPizzaPrice);

            var sausagePizza = factory.createPizza(PizzaType.Sausage);
            Assert.AreEqual(sausagePizza.Price(), _sausagePizzaPrice);
        }

        [TestMethod]
        public void NeapolitanPizzaFactory()
        {
            var factory = new NeapolitanPizzaFactory();

            var cheesePizza = factory.createPizza(PizzaType.Cheese);
            Assert.AreEqual(cheesePizza.Price(), _cheesPizzaPrice);

            var pepperoniPizza = factory.createPizza(PizzaType.Pepperoni);
            Assert.AreEqual(pepperoniPizza.Price(), _pepperoniPizzaPrice);

            var sausagePizza = factory.createPizza(PizzaType.Sausage);
            Assert.IsNull(sausagePizza);
        }


        [TestMethod]
        public void ChicagoPizzaFactory()
        {
            var factory = new ChicagoPizzaFactory();

            var cheesePizza = factory.createPizza(PizzaType.Cheese);
            Assert.AreEqual(cheesePizza.Price(), _cheesPizzaPrice);

            var pepperoniPizza = factory.createPizza(PizzaType.Pepperoni);
            Assert.IsNull(pepperoniPizza);

            var sausagePizza = factory.createPizza(PizzaType.Sausage);
            Assert.AreEqual(sausagePizza.Price(), _sausagePizzaPrice);
        }


        [TestMethod]
        public void NewYorkPizzaFactory()
        {
            var factory = new NewYorkPizzaFactory();

            var cheesePizza = factory.createPizza(PizzaType.Cheese);
            Assert.IsNull(cheesePizza);

            var pepperoniPizza = factory.createPizza(PizzaType.Pepperoni);
            Assert.AreEqual(pepperoniPizza.Price(), _pepperoniPizzaPrice);

            var sausagePizza = factory.createPizza(PizzaType.Sausage);
            Assert.AreEqual(sausagePizza.Price(), _sausagePizzaPrice);
        }
    }
}