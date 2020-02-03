namespace Prospa.Data.Repositories
{
    using Prospa.Data.Entities;
    using System;
    using System.Collections.Generic;

    public class ProspaRepository : IProspaRepository
    {
        private readonly List<Business> businesses;

        public ProspaRepository()
        {
            this.businesses = new List<Business>
            {
                new Business
                {
                    PartnerId = "LF",
                    Name = "Awesome Coffee House, Sydney",
                    Address = "32 Sir John Young Crescent, Sydney NSW",
                    AbnNumber = "123"
                },
                new Business
                {
                    Latitude = 14.5504085,
                    Longitude = 121.0110203,
                    PartnerId = "ELF",
                    AbnNumber = "456"
                },
                new Business
                {
                    Name = "The Best Coffee House",
                    PartnerId = "CL",
                    AbnNumber = "789"
                }
            };
        }

        public Business GetBusinessByAbnNumber(string abnNumber)
        {
            return this.businesses.Find(b => b.AbnNumber == abnNumber);
        }

        public IEnumerable<Business> GetBusinesses()
        {
            throw new NotImplementedException();
        }
    }
}