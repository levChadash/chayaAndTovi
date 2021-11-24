using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
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
        [JsonIgnore]
        public virtual ICollection<DonorsVisit> DonorsVisits { get; set; }
    }
}
