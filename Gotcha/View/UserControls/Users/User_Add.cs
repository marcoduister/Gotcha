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
            if (userController.AddUser(FirstName.Text, LastName.Text, Email.Text, Birthdate.Value, UserRol.SelectedIndex, Password.Text))
            {
                MessageBox.Show("you have create a user to upload a profile image go to Edit or account");
                Btn_Cancel_Click(null, null);
            }
            else
            {
                MessageBox.Show("this user already exist or try later again");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            User_Overview uc = new User_Overview();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
