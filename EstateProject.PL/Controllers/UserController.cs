using EstateProject.BusinessLogic;
using EstateProject.Entities;
using EstateProject.PL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstateProject.PL.Controllers
{
    public class UserController : Controller
    {
        UserBLL _userBLL;
        RoleBLL _roleBLL;
        UserRoleBLL _userRoleBLL;

        public UserController()
        {
            _userBLL = new UserBLL();
            _roleBLL = new RoleBLL();
            _userRoleBLL = new UserRoleBLL();
        }

        public IActionResult Index()
        {
            return View();
        }
 

        public ActionResult CreateUser()
        {
            GetAllRoleDLL();
            UserRoleViewModel user = new UserRoleViewModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult CreateUser(UserRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.HomePhone = model.HomePhone;
                user.Phone = model.Phone;
                user.UserName = model.UserName;
                user.Password = model.Password;
                //user.Role.Name = model.Role.Name;


                UserRole userRole = new UserRole();
        

                try
                {
                    GetAllRoleDLL();
                    _userBLL.Add(user);

                    userRole.UserId = user.UserId;
                    userRole.RoleId = model.RoleId;

                    _userRoleBLL.Add(userRole);
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

        private void GetAllRoleDLL()
        {
            List<SelectListItem> role = new List<SelectListItem>();
            foreach (Role item in _roleBLL.GetAll())
            {
                role.Add(new SelectListItem { Text = item.Name, Value = item.RoleId.ToString() });
            }
            ViewBag.Role = role;
        }


        public ActionResult ListUser()
        {
            return View(_userBLL.GetAll());
        }

        public ActionResult UpdateUser(int id)
        {
            User user = null;

            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                user = _userBLL.GetUser(id);
                if (user != null)
                {
                    GetAllRoleDLL();
                    return View(user);
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateUser(UserRoleViewModel model)
        {
            User user = _userBLL.GetUser(model.UserId);
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.HomePhone = model.HomePhone;
            user.Phone = model.Phone;
            user.UserName = model.UserName;
            user.Password = model.Password;


            _userBLL.Update(user);
            ViewBag.Check = false;
            return RedirectToAction("ListUser");
        }

        public ActionResult DeleteUser(int id)
        {
            User user = null;
            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                user = _userBLL.GetUser(id);
                if (user != null)
                {
                    _userBLL.Delete(user);
                    return RedirectToAction("ListUser");
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }
    }
}
