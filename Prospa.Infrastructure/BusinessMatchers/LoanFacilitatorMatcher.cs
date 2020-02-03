namespace Prospa.Infrastructure.BusinessMatchers
{
    using Prospa.Data.Entities;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class LoanFacilitatorMatcher : IBusinessMatcher
    {
        public bool IsMatch(Business business, Business databaseBusiness)
        {
            var businessName = this.RemovePunctuation(business.Name);
            var databaseBusinessName = this.RemovePunctuation(databaseBusiness.Name);
            var address = this.RemovePunctuation(business.Address);
            var databaseAddress = this.RemovePunctuation(databaseBusiness.Address);
            //Regex.Replace(business.Name, @"[^\w\d\s]", string.Empty);
            return (businessName == databaseBusinessName) && (address == databaseAddress);
        }

        private string RemovePunctuation(string businessName)
        {
            return new string(businessName.Where(c => !char.IsPunctuation(c)).ToArray()).Replace(" ", string.Empty);
        }
    }
}