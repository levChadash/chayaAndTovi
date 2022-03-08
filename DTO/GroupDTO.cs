using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace DTO
{
    public class GroupDTO
    {

        public int Id { get; set; }

        public int TeamHeadId { get; set; }
        public string TeamHeadName { get; set; }
        public int Year { get; set; }
        public int GroupNum { get; set; }
        public string Password { get; set; }
        public bool WithCar { get; set; }
        [NotMapped]
        public string Token { get; set; }
    }
}
