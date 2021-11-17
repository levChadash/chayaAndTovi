using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstWebApiSite.Models
{
    public partial class Group
    {
        public Group()
        {
            DonorsVisits = new HashSet<DonorsVisit>();
            Massages = new HashSet<Massage>();
            RaisesInGroups = new HashSet<RaisesInGroup>();
        }

        public int Id { get; set; }
        public int TeamHeadId { get; set; }
        public int Year { get; set; }
        public int GroupNum { get; set; }
        public string Password { get; set; }
        public bool WithCar { get; set; }
        public int? PreferredTimeId { get; set; }

        public virtual Time PreferredTime { get; set; }
        public virtual Raise TeamHead { get; set; }
        public virtual ICollection<DonorsVisit> DonorsVisits { get; set; }
        public virtual ICollection<Massage> Massages { get; set; }
        public virtual ICollection<RaisesInGroup> RaisesInGroups { get; set; }
    }
}
