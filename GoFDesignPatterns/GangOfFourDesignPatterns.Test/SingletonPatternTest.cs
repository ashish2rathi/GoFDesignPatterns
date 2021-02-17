using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonPattern;

namespace GangOfFourDesignPatterns.Test
{
    [TestClass]
    public class SingletonPatternTest
    {
        [TestMethod]
        public void MultipleCallsShouldReturnSameInstance()
        {
            var first = SingletonClass.Instance;
            var second = SingletonClass.Instance;
            Assert.AreSame(first, second);
            first.Value++;
            Assert.AreEqual(first.Value, second.Value);
            second.Value++;
            Assert.AreEqual(first.Value, second.Value);
            first.Dispose();
            second.Dispose();
        }
    }
}