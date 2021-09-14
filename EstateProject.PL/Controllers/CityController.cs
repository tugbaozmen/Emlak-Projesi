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
    public class CityController : Controller
    {
        CityBLL _cityBLL;

        public CityController()
        {
            _cityBLL = new CityBLL();
        }

        public IActionResult Index()
        {
            return View();
        }


        public ActionResult CreateCity()
        {
            City city = new City();
            return View(city);
        }

        [HttpPost]
        public ActionResult CreateCity(City model)
        {
            if (ModelState.IsValid)
            {
                City city = new City();
                city.CityName = model.CityName;


                try
                {
                    _cityBLL.Add(city);
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


        public ActionResult ListCity()
        {
            return View(_cityBLL.GetAll());
        }

        public ActionResult UpdateCity(int id)
        {
            City city = null;

            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                city = _cityBLL.GetCity(id);
                if (city != null)
                {
                    return View(city);
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateCity(City model)
        {
            City city = _cityBLL.GetCity(model.CityId);
            city.CityName = model.CityName;


            _cityBLL.Update(city);
            ViewBag.Check = false;
            return RedirectToAction("ListCity");
        }

        public ActionResult DeleteCity(int id)
        {
            City city = null;
            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                city = _cityBLL.GetCity(id);
                if (city != null)
                {
                    _cityBLL.Delete(city);
                    return RedirectToAction("ListCity");
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
