using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity
{
    public class user
    {
        public int id { get; set; }
        [EmailAddress]

        [Required]
        public string email { get; set; }
        public string fName { get; set; }
        public string  lName { get; set; }
        [MaxLength(7)]
        public string password { get; set; }
        


    }
}
