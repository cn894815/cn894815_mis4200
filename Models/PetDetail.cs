using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cn894815_mis4200.Models
{
    public class PetDetail
    {
        public int petDetailID { get; set; }
        public string weight { get; set; }
        public string breed { get; set; }
        public DateTime lastVisit { get; set; }

        public int PetID { get; set; }

        public virtual Pet Pet { get; set; }

        public int ownerID { get; set; }

        public virtual Owner Owner { get; set; }



    }
}