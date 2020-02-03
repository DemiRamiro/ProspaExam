namespace Prospa.Infrastructure.Factories
{
    using Prospa.Infrastructure.BusinessMatchers;

    public static class BusinessMatcherFactory
    {
        public static IBusinessMatcher Create(string partnerId)
        {
            switch (partnerId)
            {
                case "LF":
                    return new LoanFacilitatorMatcher();

                case "ELF":
                    return new EasyLoanFinderBusinessMatcher();

                case "CL":
                    return new CommercialLoansBusinessMatcher();

                default:
                    return new NullBusinessMatcher();
            }
        }
    }
}