using Gotcha.BUS;
using Gotcha.Models;
using Gotcha.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        internal bool Login(string Email, string Password)
        {
            bool login = Valideergebruiker(new User { Email = Email, Password = Password });

            if (login)
            {
                User curentUser = GetUserId(Email);
                Properties.Settings.Default["UserId"] = curentUser.Id.ToString();
                Properties.Settings.Default["UserRol"] = (int)curentUser.Rol;
                Properties.Settings.Default.Save();
            }

            return login;
        }

        private bool Valideergebruiker(User user)
        {
            return DBContext.Users.Any(e => e.Email == user.Email && e.Password == user.Password && e.Rol != Enums.Rolen.Player);
        }
        internal User GetUserId(string Email)
        {
            return DBContext.Users.First(e => e.Email == Email);
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

        internal void Logout()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name != "LoginForm")
                {
                    fm.Close();
                    Properties.Settings.Default["UserId"] = "";
                    Properties.Settings.Default["UserRol"] = 0;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
