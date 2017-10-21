using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassDemo.Context;
using ClassDemo.Models;
using System.Data.Entity;

namespace ClassDemo.Controllers
{
    [IsAdmin]
    public class ItemTypeController : BaseController
    {
        Colors col = new Colors();
        ProjectManagementDbContext db = new ProjectManagementDbContext();
        public ActionResult ItemTypeView()
        {
            ViewBag.ColorCode = new SelectList(col.GetColors(), "Value", "Text");
            ItemType it = new ItemType();
            return View(db.ItemTypes.ToList());
        }
        [HttpPost]
        public ActionResult ItemTypeView(ItemType it)
        {
            if(ModelState.IsValid)
            {
                ViewBag.ColorCode = new SelectList(col.GetColors(), "Value", "Text");
                db.ItemTypes.Add(it);
                db.SaveChanges();
                return RedirectToAction("ItemTypeView");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            ItemType it = db.ItemTypes.Find(id);
            db.ItemTypes.Remove(it);
            db.SaveChanges();
            return RedirectToAction("ItemTypeView");
        }
        public ActionResult Edit(int id)
        {
            ViewBag.ColorCode = new SelectList(col.GetColors(), "Value", "Text");
            ItemType it = db.ItemTypes.Find(id);
            return View(it);
        }
        [HttpPost]
        public ActionResult Edit(ItemType it)
        {
            ViewBag.ColorCode = new SelectList(col.GetColors(), "Value", "Text");
            db.Entry(it).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ItemTypeView");
        }
    }
}