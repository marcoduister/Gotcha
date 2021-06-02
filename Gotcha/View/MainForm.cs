using Gotcha.View.UserControls.Game;
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
        public MainForm()
        {
            InitializeComponent();
        }


        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game_Overview uc = new Game_Overview();
            uc.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(uc);

        }
    }
}
