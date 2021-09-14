using EstateProject.DataAccess.EntityFrameworkCore;
using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.BusinessLogic
{
    public class CountyBLL : IBaseService<County>
    {
        CountyDAL<County> countyDAL;

        public CountyBLL()
        {
            countyDAL = new CountyDAL<County>();
        }

        public bool Add(County entity)
        {
            try
            {
                return countyDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(County entity)
        {
            try
            {
                return countyDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<County> GetAll()
        {
            try
            {
                return countyDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public County GetById(int id)
        {
            try
            {
                return countyDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(County entity)
        {
            try
            {
                return countyDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public County GetCounty(int id)
        {
            try
            {
                return countyDAL.GetCounty(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
