using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_MVC_dz3.Models;

namespace ASP_MVC_dz3.Controllers
{
    public class RoleController : Controller
    {
        IRepository<Role> role = RoleRepository.Instanse;
        // GET: Role
        public ActionResult Index()
        {
            if (RoleRepository.Instanse._role.Count == 0)
            {
                role.FirstStart();
            }
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( Role value)
        {
            value.Id = RoleRepository.Instanse._role.Count;
            role.Add(value);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            ViewBag.newRole = role.Get((int)id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int? id, string Name)
        {
            role.Get((int)id).Name = Name;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            role.Delete((int)id);
            return RedirectToAction("Index");
        }
    }
}