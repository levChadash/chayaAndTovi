using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace DTO
{
    public partial class GroupDTO
    {

        public int Id { get; set; }

        public int TeamHeadId { get; set; }
        public string TeamHead { get; set; }
        public int Year { get; set; }
        public int GroupNum { get; set; }
        public string Password { get; set; }
        public bool WithCar { get; set; }

        
    }
}
