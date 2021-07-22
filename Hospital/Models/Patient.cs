using Hospital.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Display(Name = "Full name")]
        [RegularExpression(@"^[a-zA-Z]([-']?[a-z]+)*( [a-zA-Z]([-']?[a-z]+)*)+$")]
        [Required]
        public string FullName { get; set; }

        [StringLength(60, MinimumLength = 5)]
        [Display(Name = "Place of residence")]
        public string PlaceOfResidence { get; set; }

        [DataType(DataType.Date)]
        [DateLessThanOrEqualToToday]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Receipt date")]
        [DateLessThanOrEqualToToday]
        public DateTime DateOfReceipt { get; set; }

        [Display(Name = "Doctors full name")]
        [RegularExpression(@"^[a-zA-Z]([-']?[a-z]+)*( [a-zA-Z]([-']?[a-z]+)*)+$")]
        [Required]
        public string DoctrosFullName { get; set; }

        [Display(Name = "Conclusion")]
        public string Colnclusion { get; set; }


    }
}
