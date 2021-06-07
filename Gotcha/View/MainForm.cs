using Gotcha.BUS;
using Gotcha.View.UserControls.Game;
using Gotcha.View.UserControls.GameTypes;
using Gotcha.View.UserControls.Rules;
using Gotcha.View.UserControls.Users;
using Gotcha.View.UserControls.Worden;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotcha.View
{
    public partial class MainForm : Form
    {
        UserController _UserController = new UserController();
        public MainForm()
        {
            InitializeComponent();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            Game_Overview uc = new Game_Overview();
            uc.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(uc);

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            User_Overview uc = new User_Overview();
            uc.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(uc);
        }

        private void wordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            Worden_Overview uc = new Worden_Overview();
            uc.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(uc);
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            Rules_Overview uc = new Rules_Overview();
            uc.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(uc);
        }

        private void gameTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            GameType_Overview uc = new GameType_Overview();
            uc.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(uc);
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Properties.Settings.Default["UserId"] = "";
            Properties.Settings.Default["UserRol"] = 0;
            Properties.Settings.Default.Save();
        }
    }
}
