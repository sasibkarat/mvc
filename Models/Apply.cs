using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    [Table("tblApply")]
    public class Apply
    {
        [Key]
        public int ApplicationNumber { get; set; }
        public string UserName { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApplyDate { get; set; }
        public int NoOfDays { get; set; }

        public Employe Employe { get; set; }

    }
}