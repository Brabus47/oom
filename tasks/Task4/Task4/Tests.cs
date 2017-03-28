using System;
using NUnit.Framework;
using Task4;

namespace Task4
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsAmountGreaterThanZeroHam()
        {
            Assert.Catch(() =>
            {
                Hamburger x = new Hamburger(-1);
            });
        }

        [Test]
        public void IsAmountGreaterThanZeroCheese()
        {
            Assert.Catch(() =>
            {
                Cheeseburger x = new Cheeseburger(-1);
            });
        }

        [Test]
        public void NegativeAmountHam()
        {
            Assert.Catch(() =>
            {
                Hamburger x = new Hamburger(-1);
            });
        }

        [Test]
        public void NegativeAmountCheese()
        {
            Assert.Catch(() =>
            {
                Cheeseburger x = new Cheeseburger(-1);
            });
        }
    }
}
