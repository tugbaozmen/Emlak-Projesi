using EstateProject.DataAccess.EntityFrameworkCore;
using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.BusinessLogic
{
    public class UserRoleBLL : IBaseService<UserRole>
    {
        UserRoleDAL<UserRole> userRoleDAL;

        public UserRoleBLL()
        {
            userRoleDAL = new UserRoleDAL<UserRole>();
        }

        public bool Add(UserRole entity)
        {
            try
            {
                return userRoleDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(UserRole entity)
        {
            try
            {
                return userRoleDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UserRole> GetAll()
        {
            try
            {
                return userRoleDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserRole GetById(int id)
        {
            try
            {
                return userRoleDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(UserRole entity)
        {
            try
            {
                return userRoleDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserRole GetUserRole(int id)
        {
            try
            {
                return userRoleDAL.GetUserRole(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
