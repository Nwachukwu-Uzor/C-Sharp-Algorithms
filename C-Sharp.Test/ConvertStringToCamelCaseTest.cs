using NUnit.Framework;
using C_Sharp.Core;

namespace C_Sharp.Test
{
    [TestFixture]
    public class ConvertStringToCamelCaseTest
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("theStealthWarrior", ConvertStringToCamelCase.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", ConvertStringToCamelCase.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}
