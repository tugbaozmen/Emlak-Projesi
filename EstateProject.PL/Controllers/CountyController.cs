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
    public class CountyController : Controller
    {
        CountyBLL _countyBLL;
        CityBLL _cityBLL;
        public CountyController()
        {
            _countyBLL = new CountyBLL();
            _cityBLL = new CityBLL();
        }



        public ActionResult CreateCounty()
        {
            GetAllCityDLL();
            CityCountyViewModel county = new CityCountyViewModel();
            return View(county);
        }

        [HttpPost]
        public ActionResult CreateCounty(CityCountyViewModel model)
        {
            if (ModelState.IsValid)
            {
                County county = new County();
                county.CountyName = model.CountyName;
                county.CityId = model.CityId;

                try
                {
                    GetAllCityDLL();
                    _countyBLL.Add(county);
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

        private void GetAllCityDLL()
        {
            List<SelectListItem> city = new List<SelectListItem>();
            foreach (City item in _cityBLL.GetAll())
            {
                city.Add(new SelectListItem { Text = item.CityName, Value = item.CityId.ToString() });
            }
            ViewBag.City = city;
        }

        public ActionResult ListCounty()
        {
            return View(_countyBLL.GetAll());
        }

        public ActionResult UpdateCounty(int id)
        {
            County county = null;

            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                county = _countyBLL.GetCounty(id);
                if (county != null)
                {
                    return View(county);
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateCounty(County model)
        {
            County county = _countyBLL.GetCounty(model.CountyId);
            county.CountyName = model.CountyName;


            _countyBLL.Update(county);
            ViewBag.Check = false;
            return RedirectToAction("ListCounty");
        }

        public ActionResult DeleteCounty(int id)
        {
            County county = null;
            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                county = _countyBLL.GetCounty(id);
                if (county != null)
                {
                    _countyBLL.Delete(county);
                    return RedirectToAction("ListCounty");
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
