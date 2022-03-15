using NUnit.Framework;
using C_Sharp.Core;

namespace C_Sharp.Test
{
    [TestFixture]
    public class FriendOrFoeTest
    {
        [Test]
        public void Test1()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, FriendOFoe.FriendOrFoe(names));
        }
    }
}
