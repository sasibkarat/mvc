using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Role { get; set; }

        public Employe Employe { get; set; }
    }
}