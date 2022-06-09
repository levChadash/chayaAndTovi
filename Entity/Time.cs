using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class Time
    {
        public Time()
        {
            DonorsVisits = new HashSet<DonorsVisit>();
            //Groups = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Time1 { get; set; }
        //
        public virtual ICollection<DonorsVisit> DonorsVisits { get; set; }
        //
        //public virtual ICollection<Group> Groups { get; set; }
    }
}
