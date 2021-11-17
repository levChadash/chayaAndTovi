using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstWebApiSite.Models
{
    public partial class Raise
    {
        public Raise()
        {
            Groups = new HashSet<Group>();
            RaisesInGroups = new HashSet<RaisesInGroup>();
            RisingVisits = new HashSet<RisingVisit>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<RaisesInGroup> RaisesInGroups { get; set; }
        public virtual ICollection<RisingVisit> RisingVisits { get; set; }
    }
}
