using EstateProject.DataAccess.EntityFrameworkCore;
using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.BusinessLogic
{
    public class EstateTypeBLL : IBaseService<EstateType>
    {
        EstateTypeDAL<EstateType> estateTypeDAL;

        public EstateTypeBLL()
        {
            estateTypeDAL = new EstateTypeDAL<EstateType>();
        }

        public bool Add(EstateType entity)
        {
            try
            {
                return estateTypeDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(EstateType entity)
        {
            try
            {
                return estateTypeDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EstateType> GetAll()
        {
            try
            {
                return estateTypeDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EstateType GetById(int id)
        {
            try
            {
                return estateTypeDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(EstateType entity)
        {
            try
            {
                return estateTypeDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EstateType GetEstateType(int id)
        {
            try
            {
                return estateTypeDAL.GetEstateType(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
