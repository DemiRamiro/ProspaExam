namespace Prospa.Infrastructure.BusinessMatchers
{
    using Prospa.Data.Entities;
    using System.Linq;

    public class CommercialLoansBusinessMatcher : IBusinessMatcher
    {
        public bool IsMatch(Business business, Business databaseBusiness)
        {
            var businessName = string.Join(" ", business.Name.Split(' ').Reverse());
            return businessName == databaseBusiness.Name;
        }
    }
}