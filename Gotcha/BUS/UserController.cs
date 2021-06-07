using Gotcha.BUS;
using Gotcha.Models;
using Gotcha.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gotcha.BUS
{
    class UserController
    {
        Gotcha_DBcontext DBContext = new Gotcha_DBcontext();
        public string AddUser(string FirstName, string LastName, string Email, DateTime Birthdate, int UserRol, string Password)
        {
            User user = new User();

            user.FirstName = FirstName;
            user.LastName = LastName;
            user.Email = Email;
            user.Birthdate = Birthdate;
            user.UserActive = true;
            user.Password = Password;
            
            if (UserRol == 0)
            {
                user.Rol = Enums.Rolen.Player;
            }else if (UserRol == 1)
            {
                user.Rol = Enums.Rolen.Gamemaster;
            }else if (UserRol == 2)
            {
                user.Rol = Enums.Rolen.Admin;
            }

            DBContext.Users.Add(user);
            DBContext.SaveChanges();
            return "User has been made.";
        }
        public string EditUser(string FirstName, string LastName, string Email, DateTime Birthdate, int UserRol, Guid Id)
        {
            User user = new User();

            user.Id = Id;
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.Email = Email;
            user.Birthdate = Birthdate;
            user.UserActive = true;

            if (UserRol == 0)
            {
                user.Rol = Enums.Rolen.Player;
            }
            else if (UserRol == 1)
            {
                user.Rol = Enums.Rolen.Gamemaster;
            }
            else if (UserRol == 2)
            {
                user.Rol = Enums.Rolen.Admin;
            }

            DBContext.Users.Add(user);
            DBContext.Entry(user).State = EntityState.Modified;
            DBContext.SaveChanges();

            return "User has been updated.";
        }
        public bool DeleteUser(Guid User_Id)
        {
            try
            {
                User DeleteUser = DBContext.Users.First(i => i.Id == User_Id);
                DBContext.Remove(DeleteUser);
                DBContext.SaveChanges();

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        public User GetUser(Guid User_id)
        {
            return DBContext.Users.First(e => e.Id == User_id);
        }
        public List<User> GetAllUsers()
        {
            try
            {
                List<User> UsersList = DBContext.Users.ToList();

                return UsersList;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
    }
}
