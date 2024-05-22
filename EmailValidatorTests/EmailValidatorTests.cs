using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailValidatorApp;

namespace EmailValidatorTests
{
    [TestClass]
    public class EmailValidatorTests : BaseTest
    {
        //InvalidEmails

        [TestMethod]
        public void TestInvalidNoAtSymbol()
        {
            string invalidEmails = GetTestParameter("InvalidNoAtSymbol");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidNoPeriod()
        {
            string invalidEmails = GetTestParameter("InvalidNoPeriod");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidDomain()
        {
            string invalidEmails = GetTestParameter("InvalidDomain");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidUsername()
        {
            string invalidEmails = GetTestParameter("InvalidUsername");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidDashSymbol()
        {
            string invalidEmails = GetTestParameter("InvalidDashSymbol");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidDomainAndNoAt()
        {
            string invalidEmails = GetTestParameter("InvalidDomainAndNoAt");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidDomainAndNoPeriod()
        {
            string invalidEmails = GetTestParameter("InvalidDomainAndNoPeriod");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidTwoAtSymbols()
        {
            string invalidEmails = GetTestParameter("InvalidTwoAtSymbols");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidTwoPeriods()
        {
            string invalidEmails = GetTestParameter("InvalidTwoPeriods");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void TestInvalidSpace()
        {
            string invalidEmails = GetTestParameter("InvalidSpace");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        //Valid Emails

        [TestMethod]
        public void TestValidOne()
        {
            string validEmails = GetTestParameter("ValidOne");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidTwo()
        {
            string validEmails = GetTestParameter("ValidTwo");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidThree()
        {
            string validEmails = GetTestParameter("ValidThree");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidFour()
        {
            string validEmails = GetTestParameter("ValidFour");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidFive()
        {
            string validEmails = GetTestParameter("ValidFive");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidSix()
        {
            string validEmails = GetTestParameter("ValidSix");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidSeven()
        {
            string validEmails = GetTestParameter("ValidSeven");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidEight()
        {
            string validEmails = GetTestParameter("ValidEight");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidNine()
        {
            string validEmails = GetTestParameter("ValidNine");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void TestValidTen()
        {
            string validEmails = GetTestParameter("ValidTen");
            Assert.IsFalse (EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }
    }
}
