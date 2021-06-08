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
        UserController userController = new UserController();
        public CurentUser_Overview()
        {
            InitializeComponent();
            FillTextBox();
        }
        private void FillTextBox()
        {
            User user = userController.GetUser(Guid.Parse(Properties.Settings.Default.UserId));

            FirstName.Text = user.FirstName;
            LastName.Text = user.LastName;
            Email.Text = user.Email;
            Birthdate.Value = user.Birthdate;
        }
    }
}
