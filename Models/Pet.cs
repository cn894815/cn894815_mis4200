using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cn894815_mis4200.Models
{
    public class Pet
    {
        //[Key]public System.Guid petID { get; set; }

        [Key]public int petId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Pet Name is Required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Pet birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime birthday { get; set; }
        [Display(Name = "Weight")]
        [Required(ErrorMessage = "weight needs to be input as a decimal (###.##")]
        public decimal weight { get; set; }
        [Display(Name = "Breed of Pet")]
        [Required]
        [StringLength(20)]
        public string breed { get; set; }

        public ICollection<Visits> Visits { get; set; }
        public int ownerID { get; set; }
        public virtual Owner Owner { get; set; }
    }
}