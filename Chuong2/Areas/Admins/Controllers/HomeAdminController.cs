using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chuong2.Areas.Admins.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admins/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            return View();
        }
    }
}