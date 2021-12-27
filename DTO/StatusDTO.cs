using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace DTO
{
    public partial class StatusDTO
    {
        public int Id { get; set; }
        public string Status1 { get; set; }
        public bool Happen { get; set; }

    }
}
