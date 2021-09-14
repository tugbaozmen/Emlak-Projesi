using EstateProject.BusinessLogic;
using EstateProject.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstateProject.PL.Controllers
{
    public class EstateTypeController : Controller
    {
        EstateTypeBLL _estateTypeBLL;

        public EstateTypeController()
        {
            _estateTypeBLL = new EstateTypeBLL();
        }
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult CreateEstateType()
        {
            EstateType estateType = new EstateType();
            return View(estateType);
        }

        [HttpPost]
        public ActionResult CreateEstateType(EstateType model)
        {
            if (ModelState.IsValid)
            {
                EstateType estateType = new EstateType();
                estateType.Name = model.Name;
                estateType.Description = model.Description;
                try
                {
                    _estateTypeBLL.Add(estateType);
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
