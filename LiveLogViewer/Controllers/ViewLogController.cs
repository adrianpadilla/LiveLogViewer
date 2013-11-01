using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveLogViewer.Controllers
{
    public class ViewLogController : Controller
    {
        public ActionResult Activity(int id)
        {
            return View(id);
        }
    }
}
