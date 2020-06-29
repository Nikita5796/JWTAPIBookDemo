using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DAL
{
    public interface IUser
    {
        bool AddUserDAL(User user);
        bool UserLoginDAL(string emailId, string password);

        List<User> GetAllUsersDAL();
    }
}
