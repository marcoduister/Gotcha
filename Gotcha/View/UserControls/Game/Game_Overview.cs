using Gotcha.BUS;
using System;
using System.Collections.Generic;
using Gotcha.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotcha.View.UserControls.Game
{
    public partial class Game_Overview : UserControl
    {
        private GameController _GameController = new GameController();
        public Game_Overview()
        {
            InitializeComponent();
        }

        private void Game_Overview_Load(object sender, EventArgs e)
        {

            List<Models.Game> haha = _GameController.OverView();

            foreach (var Game in haha)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_Games);
                row.Cells[0].Value = Game.Id;
                row.Cells[1].Value = Game.Name;
                row.Cells[2].Value = Game.MaxPlayers;
                row.Cells[3].Value = Game.StartTime;
                row.Cells[4].Value = Game.Location;
                row.Cells[5].Value = Game.User.FirstName+" "+Game.User.LastName;
                DataGridViewButtonCell btn_Start = new DataGridViewButtonCell() { Value = "Start" };
                DataGridViewButtonCell btn_Read = new DataGridViewButtonCell() { Value = "Read" };
                DataGridViewButtonCell btn_Edit = new DataGridViewButtonCell() { Value = "Edit" };
                DataGridViewButtonCell btn_Delete = new DataGridViewButtonCell() { Value = "Delete" };
                row.Cells[6] = btn_Start;
                row.Cells[7] = btn_Read;
                row.Cells[8] = btn_Edit;
                row.Cells[9] = btn_Delete;
                dataGridView_Games.Rows.Add(row);
            }
        }

        private void button_CreateGame_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Game_add uc = new Game_add();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
