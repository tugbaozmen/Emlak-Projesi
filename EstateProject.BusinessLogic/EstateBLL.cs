using EstateProject.DataAccess.EntityFrameworkCore;
using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.BusinessLogic
{
    public class EstateBLL : IBaseService<Estate>
    {
        EstateDAL<Estate> estateDAL;

        public EstateBLL()
        {
            estateDAL = new EstateDAL<Estate>();
        }

        public bool Add(Estate entity)
        {
            try
            {
                return estateDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Estate entity)
        {
            try
            {
                return estateDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Estate> GetAll()
        {
            try
            {
                return estateDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Estate GetById(int id)
        {
            try
            {
                return estateDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Estate entity)
        {
            try
            {
                return estateDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Estate GetEstate(int id)
        {
            try
            {
                return estateDAL.GetEstate(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
