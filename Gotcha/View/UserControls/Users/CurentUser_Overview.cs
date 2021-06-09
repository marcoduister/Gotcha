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
    public partial class CurentUser_Overview : UserControl
    {
        Guid CurentUser = Guid.Parse(Properties.Settings.Default.UserId);
        UserController userController = new UserController();
        public CurentUser_Overview()
        {
            InitializeComponent();
            FillTextBox();
        }
        private void FillTextBox()
        {
            User user = userController.GetUser(CurentUser);

            FirstName.Text = user.FirstName;
            LastName.Text = user.LastName;
            Email.Text = user.Email;
            Birthdate.Value = user.Birthdate;
        }

        private void UpdateCurentUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userController.EditCurentUser(FirstName.Text, LastName.Text, Email.Text, Birthdate.Value, CurentUser));
        }
    }
}
