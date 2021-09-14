using EstateProject.DataAccess.EntityFrameworkCore;
using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.BusinessLogic
{
    public class CityBLL : IBaseService<City>
    {
        CityDAL<City> cityDAL;

        public CityBLL()
        {
            cityDAL = new CityDAL<City>();
        }

        public bool Add(City entity)
        {
            try
            {
                return cityDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(City entity)
        {
            try
            {
                return cityDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<City> GetAll()
        {
            try
            {
                return cityDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public City GetById(int id)
        {
            try
            {
                return cityDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(City entity)
        {
            try
            {
                return cityDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public City GetCity(int id)
        {
            try
            {
                return cityDAL.GetCity(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
