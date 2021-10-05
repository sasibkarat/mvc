using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test2.Models;
namespace Test2.Controllers
{
    public class LeaveManagementController : Controller
    {
        LeaveManagementContext db = new LeaveManagementContext();

        public ActionResult welcome()
        {

            db.EmployeTable.ToList();
            db.UserTable.ToList();
            db.ApplyTable.ToList();
            db.HrTable.ToList();
            db.LeaveTable.ToList();
            db.LeaveTypeTable.ToList();
            db.UserTable.ToList();
            db.ApproveTable.ToList();

            return View();
        }
    }
}