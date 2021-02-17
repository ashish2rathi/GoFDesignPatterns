using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdapterPattern;

namespace GangOfFourDesignPatterns.Test
{
    [TestClass]
    public class AdapterPatternTest
    {

        [TestMethod]
        public void BajajAdapter()
        {
            Bike bajajBike = new BajajBike();
            var engine = bajajBike.EngineDetails();
            Assert.AreEqual(engine.EngineID, 1);
            Assert.AreEqual(engine.EngineName, "DTS-SI");
        }

        [TestMethod]
        public void HondaAdapter()
        {
            Bike hondaBike = new HondaBike();
            var engine = hondaBike.EngineDetails();
            Assert.AreEqual(engine.EngineID, 2);
            Assert.AreEqual(engine.EngineName, "Gear Engine");
        }

        [TestMethod]
        public void WithoutAdapter()
        {
            Bike bike = new Bike();
            var engine = bike.EngineDetails();
            Assert.AreEqual(engine.EngineName, "Normal Engine");
        }
    }
}
