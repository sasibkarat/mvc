using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Test2.Models
{
    [Table("tblLeaveType")]
    public class LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public int NoOfLeavesPerYear{ get; set; }

        public Employe Employe { get; set; }


    }
}