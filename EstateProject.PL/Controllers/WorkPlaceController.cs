using EstateProject.BusinessLogic;
using EstateProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstateProject.PL.Controllers
{
    public class WorkPlaceController : Controller
    {
        WorkPlaceBLL _workPlaceBLL;

        public WorkPlaceController()
        {
            _workPlaceBLL = new WorkPlaceBLL();
        }
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult CreateWorkPlace()
        {
            WorkPlace workPlace = new WorkPlace();
            return View(workPlace);
        }

        [HttpPost]
        public ActionResult CreateWorkPlace(WorkPlace model)
        {
            if (ModelState.IsValid)
            {
                WorkPlace workPlace = new WorkPlace();
                workPlace.Address = model.Address;
                workPlace.BusinessName = model.BusinessName;
                workPlace.FirstName = model.FirstName;
                workPlace.LastName = model.LastName;
                workPlace.FaxNumber = model.FaxNumber;
                workPlace.Phone = model.Phone;
                try
                {
                    _workPlaceBLL.Add(workPlace);
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
