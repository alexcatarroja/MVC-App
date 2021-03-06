using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltest.Models
{
    public class Contact
    {
        [Key]



        // Requiring field and setting values
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(ContactWebConstants.MAX_FIRST_NAME_LENGTH)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(ContactWebConstants.MAX_LAST_NAME_LENGTH)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(ContactWebConstants.MAX_EMAIL_LENGTH)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(ContactWebConstants.MAX_PHONE_LENGTH)]
        public string PhonePrimary { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number ")]
        [StringLength(ContactWebConstants.MAX_PHONE_LENGTH)]
        public string PhoneSecondary { get; set; }

        [DataType(DataType.Date)]
        public string Birthday { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(ContactWebConstants.MAX_STEET_ADDRESS_LENGTH)]
        public string StreetAddress1 { get; set; }

        [StringLength(ContactWebConstants.MAX_STEET_ADDRESS_LENGTH)]
        public string StreetAddress2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(ContactWebConstants.MAX_CITY_LENGTH)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        public int StateId { get; set; }
        public virtual State State { get; set; }

        [Required(ErrorMessage = "Zip Code is required")]
        [Display(Name = "Zip Code")]
        [RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", ErrorMessage = "Zip code is invalid.")] // US or Canada
        [StringLength(ContactWebConstants.MAX_ZIP_CODE_LENGTH)]

        public string Zip { get; set; }

        [Required(ErrorMessage = "User Id is required")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Display(Name = "Full Name")]
        public string FriendlyName => $"{FirstName} {LastName}";

        public string FriendlyAddress => string.IsNullOrWhiteSpace(StreetAddress2)
                                         ? $"{StreetAddress1}, {City}, {State.Abbreviation}, {Zip}"
                                         : $"{StreetAddress1} - {StreetAddress2}, {City}, {State.Abbreviation}, {Zip}";
    }
}
