using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
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
        public string Remark { get; set; }
        [JsonIgnore]
        public virtual ICollection<Group> Groups { get; set; }
        [JsonIgnore]
        public virtual ICollection<RaisesInGroup> RaisesInGroups { get; set; }
        [JsonIgnore]
        public virtual ICollection<RisingVisit> RisingVisits { get; set; }
        public string LastNme { get; set; }
    }
}
