using System;
using System.Collections.Generic;

#nullable disable

namespace ThirdPartyBookingApi.Entites
{
    public partial class Customer
    {
        public Customer()
        {
            GasInformations = new HashSet<GasInformation>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Country { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public byte[] Password { get; set; }

        public virtual ICollection<GasInformation> GasInformations { get; set; }
    }
}
