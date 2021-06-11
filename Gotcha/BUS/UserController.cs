using Gotcha.BUS;
using Gotcha.Models;
using Gotcha.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Drawing;

namespace Gotcha.BUS
{
    class UserController
    {
        Gotcha_DBcontext DBContext = new Gotcha_DBcontext();
        public bool AddUser(string FirstName, string LastName, string Email, DateTime Birthdate, int UserRol, string Password)
        {
            try
            {
                if (!Userexist(Email))
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
                    DBContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
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
            return DBContext.Users.AsNoTracking().Any(e => e.Email == user.Email && e.Password == user.Password && e.Rol != Enums.Rolen.Player);
        }

        internal User GetUserId(string Email)
        {
            return DBContext.Users.AsNoTracking().First(e => e.Email == Email);
        }

        internal bool Userexist(string Email)
        {
            return DBContext.Users.AsNoTracking().Any(e => e.Email == Email);
        }

        public string EditUser(string FirstName, string LastName, string Email, DateTime Birthdate, int UserRol, Guid Id)
        {
            User user = GetUser(Id);

            user.FirstName = FirstName;
            user.LastName = LastName;
            user.Email = Email;
            user.Birthdate = Birthdate;

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
                User DeleteUser = DBContext.Users.AsNoTracking().First(i => i.Id == User_Id);
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
            return DBContext.Users.AsNoTracking().First(e => e.Id == User_id);
        }

        public List<User> GetAllUsers()
        {
            try
            {
                List<User> UsersList = DBContext.Users.AsNoTracking().ToList();

                return UsersList;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public string EditCurentUser(string FirstName, string LastName, string Email, DateTime Birthdate, Guid Id)
        {
            try
            {
                User user = GetUser(Id);

                user.FirstName = FirstName;
                user.LastName = LastName;
                user.Email = Email;
                user.Birthdate = Birthdate;

                DBContext.Users.Update(user);
                DBContext.SaveChanges();
                DBContext.Entry(user).State = EntityState.Detached;
                return "Your data has been updated.";
            }
            catch (Exception)
            {

                return "something when wrong!!";
            }


            
        }
        // this turns image in to a bytearray
        public bool ImageToByteArray(System.Drawing.Image ProfilePic,Guid User_id)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    ProfilePic.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    User UpdateImageUser = DBContext.Users.AsNoTracking().First(e => e.Id == User_id);
                    UpdateImageUser.ProfileImage = ms.ToArray();
                    DBContext.Update(UpdateImageUser);
                    DBContext.SaveChanges();
                    DBContext.Entry(UpdateImageUser).State = EntityState.Detached;
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // this wil turn bytearray in to an image
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }
    }
}
