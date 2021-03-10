using System;
using System.Collections.Generic;

#nullable disable

namespace ThirdPartyBookingApi.Entites
{
    public partial class AuthCredential
    {
        public int AuthId { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public int ExpiryLength { get; set; }
        public int? Roles { get; set; }
    }
}
