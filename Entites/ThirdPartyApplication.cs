using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyBookingApi.Entites
{
    public class ThirdPartyApplication
    {
        [Key]
        public int RequestID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? DateOFBirth { get; set; }
        public string VehicleRegNo { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string BodyType { get; set; }
        public decimal PremiumAmount { get; set; }
    }
}
