using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test2.Models
{
    [Table("tbLeaveDetail")]
    public class LeaveDetails
    {
        [Key]
        public int LeaveDetailsId { get; set; }
        public int LeaveTypeId { get; set; }
        public int UsedLeaves { get; set; }
        public int BalanceLeave { get; set; }
        public string UserName { get; set; }
        public int ApplicationNo { get; set; }
        public Employe Employe { get; set; }


    }
}