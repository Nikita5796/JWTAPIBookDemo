using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.API.Services;
using BookApp.BLL;
using BookApp.DAL;
using BookApp.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.API.Controllers
{
    public class UsersController : ControllerBase
    {
        private UserServiceBLL UserObj = new UserServiceBLL(new UserDBDAL());

        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            var user = _userService.Authenticate(userParam.EmailId, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpPost]
        public ActionResult<User> AddUser(User user)
        {
            UserObj.AddUserBLL(user);

            return Ok();
        }

        //[HttpPost]
        //public ActionResult<User> UserLogin(string emailid, string password)
        //{
        //    UserObj.UserLoginBLL(emailid, password);

        //    return Ok();
        //}


    }
}