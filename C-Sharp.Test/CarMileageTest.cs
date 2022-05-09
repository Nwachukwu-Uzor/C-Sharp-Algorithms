using C_Sharp.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Test
{
    [TestFixture]
    public class CarMileageTest
    {
        [Test]
        public void ShouldWorkTest()
        {
            Assert.AreEqual(0, CarMileage.IsInteresting(3, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, CarMileage.IsInteresting(1234, new List<int>() {  }));
            Assert.AreEqual(2, CarMileage.IsInteresting(100, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, CarMileage.IsInteresting(1336, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, CarMileage.IsInteresting(1337, new List<int>() { 1337, 256 }));
            Assert.AreEqual(0, CarMileage.IsInteresting(11208, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, CarMileage.IsInteresting(11209, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, CarMileage.IsInteresting(11211, new List<int>() { 1337, 256 }));
        }
    }
}
