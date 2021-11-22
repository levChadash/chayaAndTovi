using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstWebApiSite.Models1
{
    public partial class RisingVisit
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int RaiseId { get; set; }

        public virtual Raise Raise { get; set; }
        public virtual DonorsVisit Visit { get; set; }
    }
}
