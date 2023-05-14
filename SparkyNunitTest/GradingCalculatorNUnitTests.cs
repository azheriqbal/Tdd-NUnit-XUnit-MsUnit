using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator gradingCalculator;
        [SetUp]
        public void SetUp()
        {
            gradingCalculator = new GradingCalculator();
        }

        [Test]
        public void Grading_Input91and71_GradeA() 
        {
            gradingCalculator.Score = 91;
            gradingCalculator.AttendancePercentage = 71;
            string result = gradingCalculator.GetGrade();
            Assert.Multiple(() => 
            {
                Assert.AreEqual("A", result);
                Assert.That(result, Is.EqualTo("A"));
            });
           
        }

        [Test]
        public void Grading_Input85and90_GradeB()
        {
            gradingCalculator.Score = 85;
            gradingCalculator.AttendancePercentage = 90;
            string result = gradingCalculator.GetGrade();
            Assert.Multiple(() =>
            {
                Assert.AreEqual("B", result);
                Assert.That(result, Is.EqualTo("B"));
            });

        }

        [Test]
        public void Grading_Input65and90_GradeB()
        {
            gradingCalculator.Score = 65;
            gradingCalculator.AttendancePercentage = 90;
            string result = gradingCalculator.GetGrade();
            Assert.Multiple(() =>
            {
                Assert.AreEqual("C", result);
                Assert.That(result, Is.EqualTo("C"));
            });
        }


        [Test]
        [TestCase(95,55)]
        [TestCase(65,55)]
        [TestCase(50,90)]
        public void Grading_Failure_GradeF(int score, int percentage)
        {
            gradingCalculator.Score = score;
            gradingCalculator.AttendancePercentage = percentage;
            string result = gradingCalculator.GetGrade();
            Assert.Multiple(() =>
            {
                Assert.AreEqual("F", result);
                Assert.That(result, Is.EqualTo("F"));
            });
        }

        [Test]
        [TestCase(95, 90, ExpectedResult = "A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]
        public string Grading_AllGradeLogical_GradeOutput(int score, int percentage)
        {
            gradingCalculator.Score = score;
            gradingCalculator.AttendancePercentage = percentage;
            return gradingCalculator.GetGrade();
            
        }


    }
}
