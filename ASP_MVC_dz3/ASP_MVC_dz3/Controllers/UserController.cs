using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_MVC_dz3.Models;

namespace ASP_MVC_dz3.Controllers
{
    public class UserController : Controller
    {
        IRepository<User> user = UserRepository.Instanse;
        // GET: User
        public ActionResult Index()
        {
            if (RoleRepository.Instanse._role.Count == 0)
            {
                RoleRepository.Instanse.FirstStart();
            }
            return View();
        }
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(User value, string Role)
        {
            if (ModelState.IsValid)
            {
                value.Id = UserRepository.Instanse._user.Count;
                value.Role.Name = Role;
                user.Add(value);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        public ActionResult Edit(int? id)
        {
                if (id == null)
                    return RedirectToAction("Index");
                ViewBag.newUser = user.Get((int)id);
                return View();
        }
        [HttpPost]
        public ActionResult Edit(int? id, User newUser, string Role)
        {
            user.Get((int)id).FirstName = newUser.FirstName;
            user.Get((int)id).LastName = newUser.LastName;
            user.Get((int)id).Login = newUser.Login;
            user.Get((int)id).Password = newUser.Password;
            user.Get((int)id).Phone = newUser.Phone;
            user.Get((int)id).Email = newUser.Email;
            user.Get((int)id).Role.Name = Role;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            user.Delete((int)id);
            return RedirectToAction("Index");
        }
    }
}