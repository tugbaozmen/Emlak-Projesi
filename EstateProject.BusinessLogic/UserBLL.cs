using EstateProject.DataAccess.EntityFrameworkCore;
using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.BusinessLogic
{
    public class UserBLL : IBaseService<User>
    {
        UserDAL<User> userDAL;

        public UserBLL()
        {
            userDAL = new UserDAL<User>();
        }

        public bool Add(User entity)
        {
            try
            {
                return userDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(User entity)
        {
            try
            {
                return userDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return userDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetById(int id)
        {
            try
            {
                return userDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(User entity)
        {
            try
            {
                return userDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUser(int id)
        {
            try
            {
                return userDAL.GetUser(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
