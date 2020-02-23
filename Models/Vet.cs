﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cn894815_mis4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Pet Name is Required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Most Used Email Address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter you most frequently used email address")]

        public string email { get; set; }
        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone number must be in (xxx) xxx-xxxx or xxx-xxx-xxx")]
        public string phone { get; set; }
        [Display(Name ="When did you become a vet")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode = true)]

        public Nullable<System.DateTime> vetSince { get; set; }

        public ICollection<Visits> Visits { get; set; }
    }
}