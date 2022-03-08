using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace DTO
{
    public  class DonorsVisitDTO
    {

        public int Id { get; set; }
        public int DonorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string address { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public int? Degree { get; set; }
        public int? DonationAmount { get; set; }
        public int? PreferredTimeId { get; set; }
        public string PreferredTime { get; set; }
        public DateTime? VisitingTime { get; set; }
        public string RemarksToVisit { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public bool happen { get; set; }
        public int GroupId { get; set; }
        public int Group { get; set; }
        public int year { get; set; }
        public TimeSpan? VisitDuration { get; set; }


    }
}
