using System;
using System.Collections.Generic;

#nullable disable

namespace ThirdPartyBookingApi.Entites
{
    public partial class EncryptionKey
    {
        public int KeyId { get; set; }
        public string PublicKey { get; set; }
        public string PublicKeyXml { get; set; }
        public string PrivateKey { get; set; }
        public string PrivateKeyXml { get; set; }
    }
}
