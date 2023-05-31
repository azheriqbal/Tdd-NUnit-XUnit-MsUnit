using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount bankaccount;

        [SetUp]
        public void SetUp()
        {
            bankaccount = new(new FakerLogBook());
        }
        
        [Test]
        public void BankDeposit_Add100_ReturnTrue()
        {
            var result = bankaccount.Deposit(100);
            Assert.IsTrue(result);
            //OR
            Assert.That(bankaccount.GetBalance, Is.EqualTo(100));
        }
    }
}
