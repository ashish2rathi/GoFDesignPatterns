using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypePattern;

namespace GangOfFourDesignPatterns.Test
{
    [TestClass]
    public class PrototypePatternTest
    {
        [TestMethod]
        public void DeveloperCopy()
        {
            var developer = new Developer();
            developer.Name = "Ashish";
            developer.Role = "Team Leader";
            developer.PreferredLanguage = "C#";

            var developerClone = (Developer)developer.Clone();
            developerClone.Name = "Rathi";

            Assert.AreNotEqual(developer.Name, developerClone.Name);
            Assert.AreEqual(developer.Role, developerClone.Role);
            Assert.AreEqual(developer.PreferredLanguage, developerClone.PreferredLanguage);
        }

        [TestMethod]
        public void TesterCopy()
        {
            var tester = new Tester();
            tester.Name = "Ashish";
            tester.Role = "Team Leader";
            tester.PreferredTechnology = "Selenium";

            var testerClone = (Tester)tester.Clone();

            Assert.AreEqual(tester.Name, testerClone.Name);
            Assert.AreEqual(tester.Role, testerClone.Role);
            Assert.AreEqual(tester.PreferredTechnology, testerClone.PreferredTechnology);
        }
    }
}
