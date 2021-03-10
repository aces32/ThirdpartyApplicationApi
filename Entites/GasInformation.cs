using System;
using System.Collections.Generic;

#nullable disable

namespace ThirdPartyBookingApi.Entites
{
    public partial class GasInformation
    {
        public int GasId { get; set; }
        public string GasMobileNumber { get; set; }
        public double? GasWeight { get; set; }
        public int? Availability { get; set; }
        public string GasImage { get; set; }
        public double? Price { get; set; }
        public int? VendorsVendorId { get; set; }
        public int? CustomersCustomerId { get; set; }

        public virtual Customer CustomersCustomer { get; set; }
        public virtual Vendor VendorsVendor { get; set; }
    }
}
