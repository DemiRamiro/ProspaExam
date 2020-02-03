namespace Prospa.Services.Services
{
    using Prospa.Data.Entities;

    public interface ILoanService
    {
        bool Process(Business business);
    }
}