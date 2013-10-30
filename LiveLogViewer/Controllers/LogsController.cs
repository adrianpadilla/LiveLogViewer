using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveLogViewer.Controllers
{
    public class LogsController : Controller
    {
        public ActionResult ViewLog(int id)
        {
            return View(id);
        }
    }
}
