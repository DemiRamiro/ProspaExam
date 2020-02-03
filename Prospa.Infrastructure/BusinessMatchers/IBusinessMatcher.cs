namespace Prospa.Infrastructure.BusinessMatchers
{
    using Prospa.Data.Entities;

    public interface IBusinessMatcher
    {
        bool IsMatch(Business business, Business databaseBusiness);
    }
}