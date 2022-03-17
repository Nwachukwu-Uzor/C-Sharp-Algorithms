using NUnit.Framework;
using C_Sharp.Core;

namespace C_Sharp.Test
{
    [TestFixture]
    public class MostFrequentDayTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new[] { "Friday", "Saturday" }, MostFrequentDay.MostFrequentDays(2016));
            Assert.AreEqual(new[] { "Monday" }, MostFrequentDay.MostFrequentDays(1770));
            Assert.AreEqual(new[] { "Monday" }, MostFrequentDay.MostFrequentDays(2001));
            Assert.AreEqual(new[] { "Monday", "Tuesday" }, MostFrequentDay.MostFrequentDays(1968));
            Assert.AreEqual(new[] { "Saturday" }, MostFrequentDay.MostFrequentDays(1785));
            Assert.AreEqual(new[] { "Saturday" }, MostFrequentDay.MostFrequentDays(1910));
            Assert.AreEqual(new[] { "Saturday" }, MostFrequentDay.MostFrequentDays(2135));
            Assert.AreEqual(new[] { "Sunday" }, MostFrequentDay.MostFrequentDays(3043));
            Assert.AreEqual(new[] { "Sunday" }, MostFrequentDay.MostFrequentDays(3150));
            Assert.AreEqual(new[] { "Thursday" }, MostFrequentDay.MostFrequentDays(3361));
            Assert.AreEqual(new[] { "Tuesday" }, MostFrequentDay.MostFrequentDays(1901));
            Assert.AreEqual(new[] { "Tuesday" }, MostFrequentDay.MostFrequentDays(3230));
            Assert.AreEqual(new[] { "Wednesday" }, MostFrequentDay.MostFrequentDays(1794));
            Assert.AreEqual(new[] { "Wednesday" }, MostFrequentDay.MostFrequentDays(1986));
        }
    }
}
