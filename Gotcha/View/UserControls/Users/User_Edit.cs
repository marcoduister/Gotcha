using Gotcha.BUS;
using Gotcha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotcha.View.UserControls.Users
{
    public partial class User_Edit : UserControl
    {
        UserController userController = new UserController();
        Guid User_Id;
        public User_Edit(Guid Id)
        {
            User_Id = Id;

            InitializeComponent();

            if (Properties.Settings.Default.UserRol != 2)
            {
                UserRol.Visible = false;
                label6.Visible = false;
            }

            UserRol.DataSource = Enum.GetValues(typeof(Enums.Rolen));
            FillTextBox();
        }

        private void FillTextBox()
        {
            User user = userController.GetUser(User_Id);

            FirstName.Text = user.FirstName;
            LastName.Text = user.LastName;
            Email.Text = user.Email;
            Birthdate.Value = user.Birthdate;

            if (user.Rol == Enums.Rolen.Player)
            {
                UserRol.SelectedIndex = 0;
            }
            else if (user.Rol == Enums.Rolen.Gamemaster)
            {
                UserRol.SelectedIndex = 1;
            }
            else
            {
                UserRol.SelectedIndex = 2;
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userController.EditUser(FirstName.Text, LastName.Text, Email.Text, Birthdate.Value, UserRol.SelectedIndex, User_Id));
        }
    }
}
