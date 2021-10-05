using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Test2.Models
{
    [Table("tblApprove")]
    public class Approve
    {
        [Key]
        public int ApproveNo { get; set; }
        public DateTime ApproveDate { get; set; }
        public string ApproveStatus { get; set; }
        public string UserName { get; set; }


        public Employe Employe { get; set; }

    }
}