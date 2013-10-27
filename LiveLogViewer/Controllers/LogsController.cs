using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveLogViewer.Controllers
{
    public class LogsController : Controller
    {
        //
        // GET: /Logs/

        public ActionResult ViewLog()
        {
            return View();
        }

        public ActionResult Index()
        {
            return ViewLog();
        }

        //
        // GET: /Logs/Details/5

        public ActionResult Details(int id)
        {
            return ViewLog();
        }

        //
        // GET: /Logs/Create

        public ActionResult Create()
        {
            return ViewLog();
        }

        //
        // POST: /Logs/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return ViewLog();
            }
        }

        //
        // GET: /Logs/Edit/5

        public ActionResult Edit(int id)
        {
            return ViewLog();
        }

        //
        // POST: /Logs/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return ViewLog();
            }
        }

        //
        // GET: /Logs/Delete/5

        public ActionResult Delete(int id)
        {
            return ViewLog();
        }

        //
        // POST: /Logs/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return ViewLog();
            }
        }
    }
}
