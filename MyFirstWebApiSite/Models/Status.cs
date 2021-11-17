using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstWebApiSite.Models
{
    public partial class Status
    {
        public Status()
        {
            DonorsVisits = new HashSet<DonorsVisit>();
        }

        public int Id { get; set; }
        public string Status1 { get; set; }
        public bool Happen { get; set; }

        public virtual ICollection<DonorsVisit> DonorsVisits { get; set; }
    }
}
