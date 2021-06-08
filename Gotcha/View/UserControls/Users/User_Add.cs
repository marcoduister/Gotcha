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
    public partial class User_Add : UserControl
    {
        UserController userController = new UserController();
        public User_Add()
        {
            InitializeComponent();

            if (Properties.Settings.Default.UserRol != 2)
            {
                UserRol.Visible = false;
                label6.Visible = false;
                Password.Visible = false;
                label7.Visible = false;
            }

            UserRol.DataSource = Enum.GetValues(typeof(Enums.Rolen));
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userController.AddUser(FirstName.Text, LastName.Text, Email.Text, Birthdate.Value, UserRol.SelectedIndex, Password.Text));
        }
    }
}
