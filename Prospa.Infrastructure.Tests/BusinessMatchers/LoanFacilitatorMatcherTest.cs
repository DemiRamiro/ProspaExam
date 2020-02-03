namespace Prospa.Infrastructure.Tests.BusinessMatchers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Prospa.Data.Entities;
    using Prospa.Infrastructure.BusinessMatchers;

    [TestClass]
    public class LoanFacilitatorMatcherTest
    {
        private LoanFacilitatorMatcher businessMatcher;

        [TestInitialize]
        public void Setup()
        {
            this.businessMatcher = new LoanFacilitatorMatcher();
        }

        [TestMethod]
        public void IsMatch_NameMatchesAndAddressMatches_ReturnsTrue()
        {
            var business = new Business
            {
                Name = "*Awesome*- Coffee! House (Sydney)",
                Address = "“32 Sir John - Young Crescent, Sydney, NSW."
            };
            var databaseBusiness = new Business
            {
                Name = "Awesome Coffee House, Sydney",
                Address = "32 Sir John Young Crescent, Sydney NSW"
            };
            var actual = this.businessMatcher.IsMatch(business, databaseBusiness);
            Assert.IsTrue(actual);
        }
    }
}