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
            string validEmails = GetTestParameter("InvalidNoAtSymbol");
        }

        [TestMethod]
        public void InvalidNoPeriod()
        {
            string validEmails = GetTestParameter("InvalidNoPeriod");
        }

        [TestMethod]
        public void InvalidDomain()
        {
            string validEmails = GetTestParameter("InvalidDomain");
        }

        [TestMethod]
        public void InvalidUsername()
        {
            string validEmails = GetTestParameter("InvalidUsername");
        }

        [TestMethod]
        public void InvalidNoAtAndPeriodl()
        {
            string validEmails = GetTestParameter("InvalidNoAtAndPeriod");
        }

        [TestMethod]
        public void InvalidDomainAndNoAt()
        {
            string validEmails = GetTestParameter("InvalidDomainAndNoAt");
        }

        [TestMethod]
        public void InvalidDomainAndNoPeriod()
        {
            string validEmails = GetTestParameter("InvalidDomainAndNoPeriod");
        }

        [TestMethod]
        public void InvalidTwoAtSymbols()
        {
            string validEmails = GetTestParameter("InvalidTwoAtSymbols");
        }

        [TestMethod]
        public void InvalidTwoPeriods()
        {
            string validEmails = GetTestParameter("InvalidTwoPeriods");
        }

        [TestMethod]
        public void InvalidMultiplePeriods()
        {
            string validEmails = GetTestParameter("InvalidMultiplePeriods");
        }

        //Valid Emails

        [TestMethod]
        public void ValidOne()
        {
            string invalidEmails = GetTestParameter("ValidOne");
        }

        [TestMethod]
        public void ValidTwo()
        {
            string invalidEmails = GetTestParameter("ValidTwo");
        }

        [TestMethod]
        public void ValidThree()
        {
            string invalidEmails = GetTestParameter("ValidThree");
        }

        [TestMethod]
        public void ValidFour()
        {
            string invalidEmails = GetTestParameter("ValidFour");
        }

        [TestMethod]
        public void ValidFive()
        {
            string invalidEmails = GetTestParameter("ValidFive");
        }

        [TestMethod]
        public void ValidSix()
        {
            string invalidEmails = GetTestParameter("ValidSix");
        }

        [TestMethod]
        public void ValidSeven()
        {
            string invalidEmails = GetTestParameter("ValidSeven");
        }

        [TestMethod]
        public void ValidEight()
        {
            string invalidEmails = GetTestParameter("ValidEight");
        }

        [TestMethod]
        public void ValidNine()
        {
            string invalidEmails = GetTestParameter("ValidNine");
        }

        [TestMethod]
        public void ValidTen()
        {
            string invalidEmails = GetTestParameter("ValidTen");
        }
    }
}
