namespace Prospa.Infrastructure.Tests.BusinessMatchers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Prospa.Data.Entities;
    using Prospa.Infrastructure.BusinessMatchers;

    [TestClass]
    public class CommercialLoansBusinessMatcherTest
    {
        private CommercialLoansBusinessMatcher businessMatcher;

        [TestInitialize]
        public void Setup()
        {
            this.businessMatcher = new CommercialLoansBusinessMatcher();
        }

        [TestMethod]
        public void IsMatch_NameMatchesAndAddressMatches_ReturnsTrue()
        {
            var business = new Business
            {
                Name = "House Coffee Best The",
            };
            var databaseBusiness = new Business
            {
                Name = "The Best Coffee House",
            };
            var actual = this.businessMatcher.IsMatch(business, databaseBusiness);
            Assert.IsTrue(actual);
        }
    }
}