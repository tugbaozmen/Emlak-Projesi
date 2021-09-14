using EstateProject.DataAccess.EntityFrameworkCore;
using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.BusinessLogic
{
    public class WorkPlaceBLL : IBaseService<WorkPlace>
    {
        WorkPlaceDAL<WorkPlace> workPlaceDAL;

        public WorkPlaceBLL()
        {
            workPlaceDAL = new WorkPlaceDAL<WorkPlace>();
        }

        public bool Add(WorkPlace entity)
        {
            try
            {
                return workPlaceDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(WorkPlace entity)
        {
            try
            {
                return workPlaceDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<WorkPlace> GetAll()
        {
            try
            {
                return workPlaceDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WorkPlace GetById(int id)
        {
            try
            {
                return workPlaceDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(WorkPlace entity)
        {
            try
            {
                return workPlaceDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public WorkPlace GetWorkPlace(int id)
        {
            try
            {
                return workPlaceDAL.GetWorkPlace(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
