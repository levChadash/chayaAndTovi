using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace DTO
{
    public partial class RisingVisitDTO
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int RaiseId { get; set; }

    }
}
