using BookApp.DAL;
using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BLL
{
    public class UserServiceBLL
    {
        IUser userDAL;

        public UserServiceBLL(IUser userDAL)
        {
            this.userDAL = userDAL;
        }

        public bool AddUserBLL(User user)
        {
            bool status = false;

            try
            {
                status = userDAL.AddUserDAL(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }

        public List<User> GetAllUserBLL()
        {
            List<User> users = null;
            try
            {
                users = userDAL.GetAllUsersDAL();
                return users;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UserLoginBLL(string emailId, string password)
        {
            bool status = false;
            try
            {
                status = userDAL.UserLoginDAL(emailId, password);
                return status;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
