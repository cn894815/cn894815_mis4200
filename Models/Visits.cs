using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cn894815_mis4200.Models
{
    public class Visits
    {
        [Key] public int visitId { get; set; }

        public int vetID { get; set; }

        public virtual Vet Vet { get; set; }

        public int petID { get; set; }

        public virtual Pet Pet { get; set; }

        public DateTime dateTime { get; set; }
        public string description { get; set; }
    }
}