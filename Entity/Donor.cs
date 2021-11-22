using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstWebApiSite.Models1
{
    public partial class Donor
    {
        public Donor()
        {
            DonorsVisits = new HashSet<DonorsVisit>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNme { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNum { get; set; }
        public int? ContactId { get; set; }
        public int? Degree { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ICollection<DonorsVisit> DonorsVisits { get; set; }
    }
}
