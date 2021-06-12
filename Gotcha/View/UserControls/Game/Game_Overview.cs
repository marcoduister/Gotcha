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
            List<Models.Game> gameList = new List<Models.Game>(); 
            if ((Enums.Rolen)Properties.Settings.Default.UserRol == Enums.Rolen.Gamemaster)
            {
                gameList = _GameController.GetAllGames().Where(g => g.Maker_Id == new Guid(Properties.Settings.Default.UserId)).ToList();
            }
            else
            {
                gameList = _GameController.GetAllGames().ToList();
            }
            

            foreach (var Game in gameList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_Games);
                row.Cells[0].Value = Game.Id;
                row.Cells[1].Value = Game.Name;
                row.Cells[2].Value = Game.StartTime;
                row.Cells[3].Value = Game.Location;
                row.Cells[4].Value = Game.User.FirstName+" "+Game.User.LastName;
                if (Game.StartTime == null && !Game.Archived)
                {
                    DataGridViewButtonCell btn_Start = new DataGridViewButtonCell() { Value = "Start" };
                    row.Cells[5] = btn_Start;
                }
                if (!Game.Archived)
                {
                    DataGridViewButtonCell btn_Edit = new DataGridViewButtonCell() { Value = "Edit" };
                    row.Cells[7] = btn_Edit;

                }
                DataGridViewButtonCell btn_Delete = new DataGridViewButtonCell() { Value = "Delete" };
                row.Cells[8] = btn_Delete;

                DataGridViewButtonCell btn_Read = new DataGridViewButtonCell() { Value = "Read" };
                row.Cells[6] = btn_Read;
                
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

        private void dataGridView_Games_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid Game_id = Guid.Parse(dataGridView_Games.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_Games.Columns[e.ColumnIndex].Name == "btnStart")
            {
                if (_GameController.StartGame(Game_id))
                {
                    MessageBox.Show("you have Started a game");
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
            if (dataGridView_Games.Columns[e.ColumnIndex].Name == "btnRead")
            {
                this.Controls.Clear();
                Game_Read uc = new Game_Read(Game_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_Games.Columns[e.ColumnIndex].Name == "btnedit")
            {
                this.Controls.Clear();
                Game_Edit uc = new Game_Edit(Game_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_Games.Columns[e.ColumnIndex].Name == "btndelete")
            {
                if(_GameController.Delete(Game_id))
                {
                    MessageBox.Show("you have deleted a game");
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }
    }
}
