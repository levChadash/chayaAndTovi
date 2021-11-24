using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class Contact
    {
        public Contact()
        {
            Donors = new HashSet<Donor>();
        }

        public int Id { get; set; }
        public string ContactType { get; set; }
        [JsonIgnore]
        public virtual ICollection<Donor> Donors { get; set; }
    }
}
