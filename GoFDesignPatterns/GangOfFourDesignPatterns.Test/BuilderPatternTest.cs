using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GangOfFourDesignPatterns.Test
{
    [TestClass]
    public class BuilderPatternTest
    {
        [TestMethod]
        public void BajajBuilder()
        {
            var engineer = new VehicleEngineer(new BajajBuilder());
            engineer.CreateVehicle();
            var vehicle = engineer.GetVehicle();
            Assert.AreEqual(vehicle.Model, "Pulsar150");
            Assert.AreEqual(vehicle.Body, "Black Red");
            Assert.AreEqual(vehicle.Transmission, "120 km/hr");
            Assert.AreEqual(vehicle.Engine, "4 Stroke");
        }

        [TestMethod]
        public void HondaBuilder()
        {
            var engineer = new VehicleEngineer(new HondaBuilder());
            engineer.CreateVehicle();
            var vehicle = engineer.GetVehicle();
            Assert.AreEqual(vehicle.Model, "Suzuki125");
            Assert.AreEqual(vehicle.Body, "Red");
            Assert.AreEqual(vehicle.Transmission, "90 Km/hr");
            Assert.AreEqual(vehicle.Engine, "4 Stroke");
        }
    }
}
