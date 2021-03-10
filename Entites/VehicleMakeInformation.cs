using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyBookingApi.Entites
{
    public class VehicleMakeInformation
    {
        [Key]
        public int VehicleMakeID { get; set; }
        public string VehicleMake { get; set; }
        //public List<VehicleModelInformation> ID { get; set; }
    }
}
