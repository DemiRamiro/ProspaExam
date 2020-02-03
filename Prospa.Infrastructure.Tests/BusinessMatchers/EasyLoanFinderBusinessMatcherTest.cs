namespace Prospa.Infrastructure.Tests.BusinessMatchers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Prospa.Data.Entities;
    using Prospa.Infrastructure.BusinessMatchers;

    [TestClass]
    public class EasyLoanFinderBusinessMatcherTest
    {
        private EasyLoanFinderBusinessMatcher businessMatcher;

        [TestInitialize]
        public void Setup()
        {
            this.businessMatcher = new EasyLoanFinderBusinessMatcher();
        }

        [TestMethod]
        public void IsMatch_NameMatchesAndAddressMatches_ReturnsTrue()
        {
            var business = new Business
            {
                Latitude = 14.5511047,
                Longitude = 121.0111771
            };
            var databaseBusiness = new Business
            {
                Latitude = 14.5504085,
                Longitude = 121.0110203
            };
            var actual = this.businessMatcher.IsMatch(business, databaseBusiness);
            Assert.IsTrue(actual);
        }
    }
}