using MysqlLogin;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationApp.Tests
{
    [TestFixture]
    public class WhenRunningAirlineReservationApp
    {
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
    }
}

