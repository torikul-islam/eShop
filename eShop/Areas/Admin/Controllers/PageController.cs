using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eShop.Areas.Admin.Models;
using eShop.Models.Data;

namespace eShop.Areas.Admin.Controllers
{
    public class PageController : Controller
    {
        protected readonly DefaultConnection db = new DefaultConnection();

        // GET: Admin/Page
        public ActionResult Index()
        {
            return View(db.Pages.ToList());
        }

        // GET: Admin/Page/Details/5
        public ActionResult PageDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Page page = db.Pages.Find(id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        
        public ActionResult AddPage()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPage(Page page)
        {
            if (db.Pages.Any(t => t.Title == page.Title))
            {
                ModelState.AddModelError("", "The Title is already exits.");
            }
            if (db.Pages.Any(t => t.Slug == page.Slug))
            {
                ModelState.AddModelError("", "The Slug is already exits.");
            }

            if (ModelState.IsValid)
                {
                    db.Pages.Add(page);
                    db.SaveChanges();
                    return RedirectToAction("Index","Page");
                }
           

            return View(page);
        }

        // GET: Admin/Page/Edit/5
        public ActionResult EditPage(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Page page = db.Pages.Find(id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPage(int id, Page page)
        {
           
            if (ModelState.IsValid)
            {
                db.Entry(page).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(page);
        }

        // GET: Admin/Page/Delete/5
        public ActionResult DeletePage(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Page page = db.Pages.Find(id);
            db.Pages.Remove(page);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        // Get: Admin/Page/EditSlidebar/1
        [HttpGet]
        public ActionResult EditSidebar(int? id)
        {
            var sidebarWithId = db.Sidebars.Find(id);
            return View(sidebarWithId);
        }

        // Get: Admin/Page/EditSlidebar/1
        [HttpPost]
        public ActionResult EditSidebar(Sidebar sidebar)
        {
            if (ModelState.IsValid)
            {
                db.Sidebars.Add(sidebar);
                db.SaveChanges();
            }
            TempData["mess"] = "You have edit sidebar.";
            return RedirectToAction("EditSidebar");
        }
    }
}

