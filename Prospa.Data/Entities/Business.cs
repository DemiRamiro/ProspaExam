namespace Prospa.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class Business
    {
        public string PartnerId { get; set; }

        public string Address { get; set; }

        public string AbnNumber { get; set; }

        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
