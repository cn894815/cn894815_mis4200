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
        public DateTime birthday { get; set; }
        public string weight { get; set; }
        public string breed { get; set; }

        public ICollection<Visits> Visits { get; set; }
        public int ownerID { get; set; }
        public virtual Owner Owner { get; set; }
    }
}