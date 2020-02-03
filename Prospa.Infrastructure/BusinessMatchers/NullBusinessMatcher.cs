namespace Prospa.Infrastructure.BusinessMatchers
{
    using Prospa.Data.Entities;
    using System;

    public class NullBusinessMatcher : IBusinessMatcher
    {
        public bool IsMatch(Business business, Business databaseBusiness)
        {
            throw new NotImplementedException();
        }
    }
}