using Gotcha.BUS;
using Gotcha.Models;
using Gotcha.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.BUS
{
    class UserController
    {
        Gotcha_DBcontext DBContext = new Gotcha_DBcontext();
        public string AddUser(string FirstName, string LastName, string Email, DateTime Birthdate)
        {
            User user = new User();

            user.FirstName = FirstName;
            user.LastName = LastName;
            user.Email = Email;
            user.Birthdate = Birthdate;
            //user.Rol = Rol;

            DBContext.Users.Add(user);
            DBContext.SaveChanges();
            return "User has been made.";
        }
        public void EditUser()
        {

        }
        public void DeleteUser()
        {

        }
        public void GetUser()
        {

        }
        public void GetAllUsers()
        {

        }
    }
}
