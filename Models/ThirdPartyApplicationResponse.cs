using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyBookingApi.Models
{
    public class ThirdPartyApplicationResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string VehicleRegNo { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string BodyType { get; set; }
        public decimal PremiumAmount { get; set; }
    }
}
