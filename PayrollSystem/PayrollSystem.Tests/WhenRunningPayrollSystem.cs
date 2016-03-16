using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollSystem.Tests
{
    [TestFixture]
    public class WhenRunningPayrollSystem
    {
        [Test]
        public void When_UserEnteredEmployeeType_SalariedEmployeeShouldBeSameAsTheOutput_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.SelectedEmployeeTypeValid("Salaried employee");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredEmployeeType_HourlyEmployeeShouldBeSameAsTheOutput_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.SelectedEmployeeTypeValid("Hourly employee");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredEmployeeType_CommissionEmployeeShouldBeSameAsTheOutput_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.SelectedEmployeeTypeValid("Commission employee");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_UserEnteredEmployeeType_SalaryBasedCommissionEmployeeShouldBeSameAsTheOutput_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.SelectedEmployeeTypeValid("Base salaried commission employee");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredEmployeeType_AnyotherEmployeeType_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.SelectedEmployeeTypeValid("SBC");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredEmployeeType_NullValueEntered_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.SelectedEmployeeTypeValid("");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_UserEnteredFullName_NullValueEntered_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.userEnteredNameValid("");
             //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredFullName_ValueCanHaveMiddleName_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.userEnteredNameValid("Tasleen Kaur Pasricha");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredFullName_ValueShoudNotHaveTwoWhiteSpaces_ResultShouldBeFalse()
        {
            //prepare
            var expected = false;
            //action
            var actual = Program.userEnteredNameValid("tasleen pasricha ");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void When_UserEnteredSSNValue_FormatShouldBeAsOutput_ResultShouldBeTrue()
        {
            //prepare
            var expected = true;
            //action
            var actual = Program.userEnteredSSNValid("111-11-1111");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredSSNValue_AnyOtherValue_ResultShouldBeFalse()
        { 
            //prepare
            var expected = false;
            //action
            var actual = Program.userEnteredNameValid("1111-11-1111");
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
        
        [Test]
        public void When_UserEnteredGrossSales_ShouldBeAsExpected_ResultShouldBeTrue()
        {
            //prepare
            var expected = 72.89d;
            string sales = "72.89";
            //action
            var actual = Program.SelectedDoubleValueValid(sales);
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

      }
}
