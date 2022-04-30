using NUnit.Framework;
using Finanz_Manager;
using System.Collections.Generic;

namespace NUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void getAccountsFromDatabase()
        {
            var result = DBconnector.getAccounts();
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void getAccountIdFromName_success()
        {
            var result = DBconnector.getAccountIdFromName("Giro");
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void calculatePositiveBalcance()
        {
            List<int> amountList = new List<int>()
            {
                100,
                1050,
                20000
            };
            Calculator calc = new Calculator();

            var result = calc.calculateBalance(amountList);

            Assert.That(result, Is.EqualTo(21150));
        }

        [Test]
        public void calculateNegativeBalcance()
        {
            List<int> amountList = new List<int>()
            {
                100,
                1050,
                -20000
            };
            Calculator calc = new Calculator();

            var result = calc.calculateBalance(amountList);

            Assert.That(result, Is.EqualTo(-18850));
        }
    }
}