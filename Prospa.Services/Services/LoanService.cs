namespace Prospa.Services.Services
{
    using Prospa.Data.Entities;
    using Prospa.Data.Repositories;
    using Prospa.Infrastructure.Factories;

    public class LoanService : ILoanService
    {
        private readonly IProspaRepository repository;

        public LoanService(IProspaRepository repository)
        {
            this.repository = repository;
        }

        public bool Process(Business business)
        {
            var databaseBusiness = this.repository.GetBusinessByAbnNumber(business.AbnNumber);
            var businessMatcher = BusinessMatcherFactory.Create(business.PartnerId);
            var isMatch = businessMatcher.IsMatch(business, databaseBusiness);
            if (!isMatch)
            {
                return false;
            }

            ////continue process
            return true;
        }
    }
}