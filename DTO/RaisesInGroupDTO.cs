using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace DTO
{
    public partial class RaisesInGroupDTO
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int RaiseId { get; set; }

    }
}