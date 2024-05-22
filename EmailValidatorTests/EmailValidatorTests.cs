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
        public void InvalidNoAtSymbol()
        {
            string invalidEmails = GetTestParameter("InvalidNoAtSymbol");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidNoPeriod()
        {
            string invalidEmails = GetTestParameter("InvalidNoPeriod");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidDomain()
        {
            string invalidEmails = GetTestParameter("InvalidDomain");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidUsername()
        {
            string invalidEmails = GetTestParameter("InvalidUsername");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidNoAtAndPeriodl()
        {
            string invalidEmails = GetTestParameter("InvalidNoAtAndPeriod");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidDomainAndNoAt()
        {
            string invalidEmails = GetTestParameter("InvalidDomainAndNoAt");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidDomainAndNoPeriod()
        {
            string invalidEmails = GetTestParameter("InvalidDomainAndNoPeriod");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidTwoAtSymbols()
        {
            string invalidEmails = GetTestParameter("InvalidTwoAtSymbols");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidTwoPeriods()
        {
            string invalidEmails = GetTestParameter("InvalidTwoPeriods");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        [TestMethod]
        public void InvalidMultiplePeriods()
        {
            string invalidEmails = GetTestParameter("InvalidMultiplePeriods");
            Assert.IsFalse(EmailValidator.IsValidEmail(invalidEmails), $"Expected valid email: {invalidEmails}");
        }

        //Valid Emails

        [TestMethod]
        public void ValidOne()
        {
            string validEmails = GetTestParameter("ValidOne");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidTwo()
        {
            string validEmails = GetTestParameter("ValidTwo");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidThree()
        {
            string validEmails = GetTestParameter("ValidThree");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidFour()
        {
            string validEmails = GetTestParameter("ValidFour");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidFive()
        {
            string validEmails = GetTestParameter("ValidFive");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidSix()
        {
            string validEmails = GetTestParameter("ValidSix");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidSeven()
        {
            string validEmails = GetTestParameter("ValidSeven");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidEight()
        {
            string validEmails = GetTestParameter("ValidEight");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidNine()
        {
            string validEmails = GetTestParameter("ValidNine");
            Assert.IsFalse(EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }

        [TestMethod]
        public void ValidTen()
        {
            string validEmails = GetTestParameter("ValidTen");
            Assert.IsFalse (EmailValidator.IsValidEmail(validEmails), $"Expected valid email: {validEmails}");
        }
    }
}
