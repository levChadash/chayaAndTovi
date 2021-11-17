using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstWebApiSite.Models
{
    public partial class RaisesInGroup
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int RaiseId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Raise Raise { get; set; }
    }
}
