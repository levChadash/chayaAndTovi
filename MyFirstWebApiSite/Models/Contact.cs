using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstWebApiSite.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Donors = new HashSet<Donor>();
        }

        public int Id { get; set; }
        public string ContactType { get; set; }

        public virtual ICollection<Donor> Donors { get; set; }
    }
}
