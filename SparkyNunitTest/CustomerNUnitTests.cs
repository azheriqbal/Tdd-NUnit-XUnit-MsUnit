using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer customer;
        [SetUp]

        public void Setup()
        {
            customer = new Customer();
        }
        [Test]
        public void CombineName_InputFirstAndLastName_FullName() {

            customer.GreetAndCombineName("Ben", "Ten");

            Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Ten"));
            Assert.AreEqual(customer.GreetMessage, "Hello, Ben Ten");
            Assert.That(customer.GreetMessage, Does.Contain("ten").IgnoreCase); //Only Checks, output has ten
            Assert.That(customer.GreetMessage, Does.StartWith("Hello"));
            Assert.That(customer.GreetMessage, Does.EndWith("Ten"));
            Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}"));

        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull()
        {

            //customer.GreetAndCombineName("Ben", "Ten");

            Assert.IsNull(customer.GreetMessage);
        }




    }
}
