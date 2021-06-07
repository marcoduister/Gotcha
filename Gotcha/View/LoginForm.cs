using Gotcha.BUS;
using Gotcha.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotcha
{
    public partial class LoginForm : Form
    {
        private UserController _UserController = new UserController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //check username password
            if (_UserController.Login(Textbox_Email.Text, Texbox_Password.Text))
            {
                this.Hide();
                MainForm mainBase = new MainForm();
                mainBase.ShowDialog();
                mainBase.Dispose();
                this.Show();
                this.Textbox_Email.Text = "";
                this.Texbox_Password.Text = "";
            }
            else
            {
                MessageBox.Show("Gegevens zijn fout!!! probeer op nieuw");
            }
        }
    }
}
