using System;
using System.Collections.Generic;

#nullable disable

namespace ThirdPartyBookingApi.Entites
{
    public partial class Vendor
    {
        public Vendor()
        {
            GasInformations = new HashSet<GasInformation>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorCountry { get; set; }
        public string VendorState { get; set; }
        public string VendorLga { get; set; }
        public string VendorEmail { get; set; }
        public string VendorMobileNo { get; set; }
        public byte[] VendorPassword { get; set; }
        public string VendorType { get; set; }

        public virtual ICollection<GasInformation> GasInformations { get; set; }
    }
}
