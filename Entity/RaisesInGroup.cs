using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class RaisesInGroup
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int RaiseId { get; set; }
        [JsonIgnore]
        public virtual Group Group { get; set; }
        [JsonIgnore]
        public virtual Raise Raise { get; set; }
    }
}
