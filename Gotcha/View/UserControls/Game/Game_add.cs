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

namespace Gotcha.View.UserControls.Game
{
    public partial class Game_add : UserControl
    {
        private GameController _GameController = new GameController();
        public Game_add()
        {
            InitializeComponent();
        }

        private void Game_add_Load(object sender, EventArgs e)
        {
            comboBox_User.DataSource = _GameController.GetUsers();
            this.comboBox_User.DisplayMember = "FirstName+";
            this.comboBox_User.ValueMember = "Id";
        }

        private void Btn_CreateGame_Click(object sender, EventArgs e)
        {
            Models.Game game = new Models.Game()
            {
                Name = textBox_Name.Text,
                Location = textBox_Location.Text
            };
            _GameController.AddGame(game);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            {
                this.Controls.Clear();
                Game_Overview uc = new Game_Overview();
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
        }
    }
}
