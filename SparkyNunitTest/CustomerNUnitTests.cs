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
        [Test]
        public void CombineName_InputFirstAndLastName_FullName() {
            var customer = new Customer();

            string fullName = customer.GreetAndCombineName("Ben", "Ten");

            Assert.That(fullName, Is.EqualTo("Hello, Ben Ten"));
            Assert.AreEqual(fullName,"Hello, Ben Ten");
            Assert.That(fullName, Does.Contain("ten").IgnoreCase); //Only Checks, output has ten
            Assert.That(fullName, Does.StartWith("Hello"));
            Assert.That(fullName, Does.EndWith("Ten"));
            Assert.That(fullName, Does.Match("Hello, [A-Z]{1}"));




        }




    }
}
