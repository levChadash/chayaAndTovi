using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Entity;

#nullable disable

namespace DTO
{
    public partial class DonorDTO
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNum { get; set; }
        public int? ContactId { get; set; }
        public int? Degree { get; set; }


    }
}
