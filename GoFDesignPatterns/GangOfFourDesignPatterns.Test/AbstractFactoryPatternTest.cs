using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GangOfFourDesignPatterns.Test
{
    [TestClass]
    public class AbstractFactoryPatternTest
    {
        [TestMethod]
        public void RedmiFactory()
        {
            var factory = new RedmiFactory();
            var client = new MobileClient(factory);

            var normalPhoneRAM = client.GetNormalPhoneRAMDetails();
            Assert.AreEqual(normalPhoneRAM, RAMTypes.OneGB);

            var smartPhoneRAM = client.GetSmartPhoneRAMDetails();
            Assert.AreEqual(smartPhoneRAM, RAMTypes.TwoGB);
        }

        [TestMethod]
        public void SamsungFactory()
        {
            var factory = new SamsungFactory();
            var client = new MobileClient(factory);

            var normalPhoneRAM = client.GetNormalPhoneRAMDetails();
            Assert.AreEqual(normalPhoneRAM, RAMTypes.NA);

            var smartPhoneRAM = client.GetSmartPhoneRAMDetails();
            Assert.AreEqual(smartPhoneRAM, RAMTypes.ThreeGB);
        }
    }
}
