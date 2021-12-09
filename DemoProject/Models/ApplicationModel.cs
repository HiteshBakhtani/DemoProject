using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class ApplicationModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a fullname.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please select gender.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Contact { get; set; }

        [Display(Name = "Board/University")]
        [Required(ErrorMessage = "Please enter SSC Board.")]
        public string SSC_Board { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "Please enter SSC passing year.")]
        public string SSC_Year { get; set; }

        [Display(Name = "Percentage/CGPA")]
        [Required(ErrorMessage = "Please enter SSC Percentage/CGPA.")]
        public string SSC_Percentage { get; set; }

        [Display(Name = "Board/University")]
        [Required(ErrorMessage = "Please enter HSC Board.")]
        public string HSC_Board { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "Please enter HSC passing year.")]
        public string HSC_Year { get; set; }

        [Display(Name = "Percentage/CGPA")]
        [Required(ErrorMessage = "Please enter HSC Percentage/CGPA.")]
        public string HSC_Percentage { get; set; }

        [Display(Name = "Board/University")]
        [Required(ErrorMessage = "Please enter Graduation Board.")]
        public string Graduation_Board { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "Please enter Graduation passing year.")]
        public string Graduation_Year { get; set; }

        [Display(Name = "Percentage/CGPA")]
        [Required(ErrorMessage = "Please enter Graduation Percentage/CGPA.")]
        public string Graduation_Percentage { get; set; }
    }
}
