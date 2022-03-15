using NUnit.Framework;
using C_Sharp.Core;

namespace C_Sharp.Test
{
    [TestFixture]
    public class SubstringTest
    {
        [Test]
        public void ShouldBeTrue()
        {
            Assert.AreEqual(true, CommonSubstring.SubstringTest("Something", "Home"));
        }

        [Test]
        public void ShouldBeFalse()
        {
            Assert.AreEqual(false, CommonSubstring.SubstringTest("Something", "Fun"));
        }
    }
}
