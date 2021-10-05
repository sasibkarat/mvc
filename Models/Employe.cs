using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test2.Models
{
    [Table("tblEmploye")]
    public class Employe
    {
        [Key]
        public int EmployeId { get; set; }
        public string EmployName { get; set; }
        public int UserName { get; set; }


    }
}