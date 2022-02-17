using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{


        public partial class VisitDTO
        {

            public int Id { get; set; }
            public string DonorName { get; set; }
            public string Address { get; set; }
            
            public int? DonationAmount { get; set; }
            public int? PreferredTimeId { get; set; }
            public DateTime? VisitingTime { get; set; }
            public string RemarksToVisit { get; set; }
            public int StatusId { get; set; }
            public int GroupId { get; set; }
            public int year { get; set; }
            public TimeSpan? VisitDuration { get; set; }

        }
    }

