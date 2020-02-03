namespace Prospa.Infrastructure.BusinessMatchers
{
    using Prospa.Data.Entities;
    using System;

    public class EasyLoanFinderBusinessMatcher : IBusinessMatcher
    {
        public bool IsMatch(Business business, Business databaseBusiness)
        {
            var distance = this.GetGPSCoordinateDistance(business.Latitude, business.Longitude, databaseBusiness.Latitude, databaseBusiness.Longitude);
            return (distance <= 0.2) && (business.PartnerId == databaseBusiness.PartnerId);
        }

        private double GetGPSCoordinateDistance(double businessLat, double businessLong, double databaseLat, double databaseLong)
        {
            double earthRadius = 6371;
            var radianLat = this.DegreeToRadian(businessLat - databaseLat);
            var radianLong = this.DegreeToRadian(businessLong - databaseLong);
            var radianDatabaseLat = this.DegreeToRadian(databaseLat);
            var radianBusinessLat = this.DegreeToRadian(businessLat);

            var a = Math.Sin(radianLat / 2) * Math.Sin(radianLat / 2) + Math.Sin(radianLong / 2) * Math.Sin(radianLong / 2) * Math.Cos(radianDatabaseLat) * Math.Cos(radianBusinessLat);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = earthRadius * c;
            return d;
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180;
        }
    }
}