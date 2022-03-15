using NUnit.Framework;
using C_Sharp.Core;

namespace C_Sharp.Test
{
    [TestFixture]
    public class VolumeOfCuboidTest
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(60, VolumeOfCuboid.getVolumeOfCubiod(2, 5, 6), 0.00001, "Length: 2, Width: 5, Height: 6");
            Assert.AreEqual(94.5, VolumeOfCuboid.getVolumeOfCubiod(6.3, 3, 5), 0.00001, "Length: 6.3, Width: 3, Height: 5");
        }
    }
}
