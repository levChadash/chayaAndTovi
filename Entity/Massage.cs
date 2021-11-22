using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstWebApiSite.Models1
{
    public partial class Massage
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public string Text { get; set; }

        public virtual Group Group { get; set; }
    }
}
