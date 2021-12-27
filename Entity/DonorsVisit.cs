using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class DonorsVisit
    {
        public DonorsVisit()
        {
            RisingVisits = new HashSet<RisingVisit>();
        }

        public int Id { get; set; }
        public int DonorId { get; set; }
        public int? DonationAmount { get; set; }
        public int? PreferredTimeId { get; set; }
        public DateTime? VisitingTime { get; set; }
        public string RemarksToVisit { get; set; }
        public int StatusId { get; set; }
        public int GroupId { get; set; }
        public int year { get; set; }
        public TimeSpan? VisitDuration { get; set; }
        //
        public virtual Donor Donor { get; set; }
        //
        public virtual Group Group { get; set; }
        //
        public virtual Time PreferredTime { get; set; }
        //
        public virtual Status Status { get; set; }
        //
        public virtual ICollection<RisingVisit> RisingVisits { get; set; }
    }
}
