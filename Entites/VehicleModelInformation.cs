using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyBookingApi.Entites
{
    public class VehicleModelInformation
    {
        [Key]
        public int VehicleModelID { get; set; }
        public string VehicleModel { get; set; }
        //public List<ThirdPartyApplication> ID { get; set; }
    }
}
