using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test2.Models
{
    [Table("tblHr")]
    public class HrLogin
    {
        [Key]
        public string HrId { get; set; }
        public int Password { get; set; }

        public Employe Employe { get; set; }

    }
}