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
    public class EstateController : Controller
    {
        UserBLL _userBLL;
        EstateBLL _estateBLL;
        CityBLL _cityBLL;
        CountyBLL _countyBLL;
        WorkPlaceBLL _workPlaceBLL;
        EstateTypeBLL _estateTypeBLL;
        public EstateController()
        {
            _userBLL = new UserBLL();
            _estateBLL = new EstateBLL();
            _cityBLL = new CityBLL();
            _countyBLL = new CountyBLL();
            _workPlaceBLL = new WorkPlaceBLL();
            _estateTypeBLL = new EstateTypeBLL();
        }

        public ActionResult CreateEstate()
        {
            GetAllCityDLL();
            GetAllUserDLL();
            GetAllWorkPlaceDLL();
            GetAllCountyDLL();
            GetAllEstateTypeDLL();
            GetEstateStatusFromEnumToDLL();
            GetFrontFromEnumToDLL();
            GetWarmStatusFromEnumToDLL();
            EstateViewModel estate = new EstateViewModel();
            return View(estate);
        }

        [HttpPost]
        public ActionResult CreateEstate(EstateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Estate estate = new Estate();
                estate.EstateName = model.EstateName;
                estate.EstateStatus = model.EstateStatus;
                estate.EstateTypeId = model.EstateTypeId;
                estate.FloorStatus = model.FloorStatus;
                estate.Front = model.Front;
                estate.WarmStatus = model.WarmStatus;
                estate.NumberOfBalcony = model.NumberOfBalcony;
                estate.NumberOfBathromm = model.NumberOfBathromm;
                estate.NumberOfFloor = model.NumberOfFloor;
                estate.NumberOfRoom = model.NumberOfRoom;
                estate.NumberOfToilet = model.NumberOfToilet;
                estate.Price = model.Price;
                estate.CityId = model.CityId;
                estate.UserId = model.UserId;
                estate.WorkPlaceId = model.WorkPlaceId;


                try
                {
                    GetAllCityDLL();
                    GetAllUserDLL();
                    GetAllWorkPlaceDLL();
                    GetAllCountyDLL();
                    GetAllEstateTypeDLL();
                    GetEstateStatusFromEnumToDLL();
                    GetFrontFromEnumToDLL();
                    GetWarmStatusFromEnumToDLL();
                    _estateBLL.Add(estate);
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
        private void GetAllCountyDLL()
        {
            List<SelectListItem> county = new List<SelectListItem>();
            foreach (County item in _countyBLL.GetAll())
            {
                county.Add(new SelectListItem { Text = item.CountyName, Value = item.CountyId.ToString() });
            }
            ViewBag.County = county;
        }
        private void GetAllUserDLL()
        {
            List<SelectListItem> user = new List<SelectListItem>();
            foreach (User item in _userBLL.GetAll())
            {
                user.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName , Value = item.UserId.ToString() });
            }
            ViewBag.User = user;
        }
        private void GetAllWorkPlaceDLL()
        {
            List<SelectListItem> workPlace = new List<SelectListItem>();
            foreach (WorkPlace item in _workPlaceBLL.GetAll())
            {
                workPlace.Add(new SelectListItem { Text = item.BusinessName, Value = item.WorkPlaceId.ToString() });
            }
            ViewBag.WorkPlace = workPlace;
        }
        private void GetAllEstateTypeDLL()
        {
            List<SelectListItem> type = new List<SelectListItem>();
            foreach (EstateType item in _estateTypeBLL.GetAll())
            {
                type.Add(new SelectListItem { Text = item.Name, Value = item.EstateTypeId.ToString() });
            }
            ViewBag.EstateType = type;
        }

        private void GetEstateStatusFromEnumToDLL()
        {
            string[] estateStatusEnums = Enum.GetNames(typeof(EstateStatus));
            List<SelectListItem> estate = new List<SelectListItem>();
            foreach (string item in estateStatusEnums)
            {
                estate.Add(new SelectListItem { Text = item, Value = item });
            }
            ViewBag.EstateStatus = estate;
        }

        private void GetWarmStatusFromEnumToDLL()
        {
            string[] warmStatusEnums = Enum.GetNames(typeof(WarmStatus));
            List<SelectListItem> warm = new List<SelectListItem>();
            foreach (string item in warmStatusEnums)
            {
                warm.Add(new SelectListItem { Text = item, Value = item });
            }
            ViewBag.WarmStatus = warm;
        }
        private void GetFrontFromEnumToDLL()
        {
            string[] frontEnums = Enum.GetNames(typeof(Front));
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (string item in frontEnums)
            {
                listItems.Add(new SelectListItem { Text = item, Value = item });
            }
            ViewBag.Front = listItems;
        }
        public ActionResult ListEstate()
        {
            return View(_estateBLL.GetAll());
        }

        public ActionResult UpdateEstate(int id)
        {
            Estate estate = null;

            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                estate = _estateBLL.GetEstate(id);
                if (estate != null)
                {
                    GetAllCityDLL();
                    GetAllUserDLL();
                    GetAllWorkPlaceDLL();
                    GetAllCountyDLL();
                    GetAllEstateTypeDLL();
                    GetEstateStatusFromEnumToDLL();
                    GetFrontFromEnumToDLL();
                    GetWarmStatusFromEnumToDLL();
                    return View(estate);
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateEstate(EstateViewModel model)
        {
            Estate estate = _estateBLL.GetEstate(model.EstateId);
            estate.EstateName = model.EstateName;
            estate.EstateStatus = model.EstateStatus;
            estate.EstateTypeId = model.EstateTypeId;
            estate.FloorStatus = model.FloorStatus;
            estate.Front = model.Front;
            estate.WarmStatus = model.WarmStatus;
            estate.NumberOfBalcony = model.NumberOfBalcony;
            estate.NumberOfBathromm = model.NumberOfBathromm;
            estate.NumberOfFloor = model.NumberOfFloor;
            estate.NumberOfRoom = model.NumberOfRoom;
            estate.NumberOfToilet = model.NumberOfToilet;
            estate.Price = model.Price;
            estate.CityId = model.CityId;
            estate.UserId = model.UserId;
            estate.WorkPlaceId = model.WorkPlaceId;

            _estateBLL.Update(estate);
            ViewBag.Check = false;
            return RedirectToAction("ListEstate");
        }

        public ActionResult DeleteEstate(int id)
        {
            Estate estate = null;
            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                estate = _estateBLL.GetEstate(id);
                if (estate != null)
                {
                    _estateBLL.Delete(estate);
                    return RedirectToAction("ListEstate");
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
