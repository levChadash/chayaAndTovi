using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class RisingVisit
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int RaiseId { get; set; }
        [JsonIgnore]

        public virtual Raise Raise { get; set; }
        [JsonIgnore]
        public virtual DonorsVisit Visit { get; set; }
    }
}
