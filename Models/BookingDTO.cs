using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyBookingApi.ValidationAttributes;

namespace ThirdPartyBookingApi.Models
{
    public class BookingDTO
    {
        /// <summary>
        /// customers Firstname for booking 
        /// </summary>
        [Required(ErrorMessage = "Firstname is required")]
        //[Encrypted(ErrorMessage = "Ensure LastName is encrypted")]
        public string Firstname { get; set; }

        /// <summary>
        /// customers lastname for booking
        /// </summary>
        [Required(ErrorMessage = "Lastname is required")]
        //[Encrypted(ErrorMessage = "Ensure LastName is encrypted")]
        public string LastName { get; set; }

        /// <summary>
        /// customers email for booking
        /// </summary>
        [Required(ErrorMessage = "Email is required")]
        [ValidEmailAddress(ErrorMessage = "Invalid Email Address Format")]
        //[Encrypted(ErrorMessage = "Ensure Email Address is encrypted")]
        public string Email { get; set; }

        /// <summary>
        /// customers Date of birth for booking
        /// </summary>

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOFBirth { get; set; }

        /// <summary>
        /// customers MobileNumber for booking
        /// </summary>
        [Required(ErrorMessage = "mobileNumber is required")]
        [ValidMobileNumber(ErrorMessage = "Invalid Mobile Number Format")]
        //[Encrypted(ErrorMessage = "Ensure MobileNumber is encrypted")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// customers Vehicle Registration Number for booking
        /// </summary>
        [Required(ErrorMessage = "Vehicle registration Number is required")]
        //[Encrypted(ErrorMessage = "Ensure Password is encrypted")]
        public string VehicleRegNo { get; set; }

        /// <summary>
        /// customers Vehicle Make Number for booking
        /// </summary>

        [Required(ErrorMessage = "Vehicle Make is required")]
        public string VehicleMake { get; set; }

        /// <summary>
        /// customers Vehicle Model Number for booking
        /// </summary>

        [Required(ErrorMessage = "Vehicle Model is required")]
        public string VehicleModel { get; set; }
        /// <summary>
        /// customers Vehicle Body Type for booking
        /// </summary>

        [Required(ErrorMessage = "Body Type is required")]
        public string BodyType { get; set; }
        /// <summary>
        /// Premium Amount for third party
        /// </summary>

        [Required(ErrorMessage = "Premium Amount is required")]
        public decimal PremiumAmount { get; set; }

    }
}
