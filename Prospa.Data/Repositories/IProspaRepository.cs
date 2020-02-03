namespace Prospa.Data.Repositories
{
    using Prospa.Data.Entities;
    using System.Collections.Generic;

    public interface IProspaRepository
    {
        IEnumerable<Business> GetBusinesses();

        Business GetBusinessByAbnNumber(string abnNumber);
    }
}