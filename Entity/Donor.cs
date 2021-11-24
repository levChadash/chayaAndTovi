using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class Donor
    {
        public Donor()
        {
            DonorsVisits = new HashSet<DonorsVisit>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNum { get; set; }
        public int? ContactId { get; set; }
        public int? Degree { get; set; }
        [JsonIgnore]
        public virtual Contact Contact { get; set; }
        [JsonIgnore]
        public virtual ICollection<DonorsVisit> DonorsVisits { get; set; }
    }
}
