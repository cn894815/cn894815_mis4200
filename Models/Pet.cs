using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cn894815_mis4200.Models
{
    public class Pet
    {
        public int petID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }




        public ICollection<PetDetail> PetDetail { get; set; }
    }
}