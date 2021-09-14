using EstateProject.BusinessLogic;
using EstateProject.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstateProject.PL.Controllers
{
    public class RoleController : Controller
    {
        RoleBLL _roleBLL;

        public RoleController()
        {
            _roleBLL = new RoleBLL();
        }
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult CreateRole()
        {
            Role role = new Role();
            return View(role);
        }

        [HttpPost]
        public ActionResult CreateRole(Role model)
        {
            if (ModelState.IsValid)
            {
                Role role = new Role();
                role.Name = model.Name;
                role.Description = model.Description;
                try
                {
                    _roleBLL.Add(role);
                    ViewBag.IsSuccess = true;
                    return View(model);
                }
                catch (Exception ex)
                {
                    ViewBag.IsSuccess = false;
                    ModelState.AddModelError("", ex.Message);
                }
                return View(model);
            }
            else
            {
                ModelState.AddModelError("", "Girdiğiniz bilgileri kontrol ediniz");
            }
            return View();
        }
    }
}
