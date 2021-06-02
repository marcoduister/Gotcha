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
    public partial class User_Overview : UserControl
    {
        public User_Overview()
        {
            InitializeComponent();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            User_Add uc = new User_Add();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
