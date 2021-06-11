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
    public partial class Game_Read : UserControl
    {
        private GameController _GameController = new GameController();
        private Guid _Game_Id;

        public Game_Read(Guid Game_Id)
        {
            InitializeComponent();
            _Game_Id = Game_Id;

            Models.Game CurrentGame = Filldatagridview();


            textBox_Name.Text = CurrentGame.Name;
            textBox_Location.Text = CurrentGame.Location;
            textBoxActivePlayer.Text = CurrentGame.Contracts.Count().ToString();
            textBox_gameType.Text = CurrentGame.GameType.Name;
            textBox_ruleset.Text = CurrentGame.RuleSet.Name;
            textBox_wordset.Text = CurrentGame.WordSet.Name;
            if (CurrentGame.StartTime != null)
            {
                dateTimePicker_Start.Value = (DateTime)CurrentGame.StartTime;
            }
            if (CurrentGame.EindTime != null)
                dateTimePicker_End.Value = (DateTime)CurrentGame.EindTime;
            else
                dateTimePicker_End.Visible = false;
        }

        private Models.Game Filldatagridview()
        {
            Models.Game CurrentGame = _GameController.GetGameById(_Game_Id);
            dataGridView_gameUsers.Rows.Clear();

            // this will fill the contract list and wil fill the win textboxes
            foreach (var contract in CurrentGame.Contracts)
            {
                Contract Winner = null;
                Contract Second = null;
                Contract Most = null;

                if (CurrentGame.Contracts.Count() >= 2)
                {
                    if (CurrentGame.Contracts.OrderByDescending(e => e.EliminatedTime).Any(e =>e.Eliminations >0))
                    {
                        if (CurrentGame.Contracts.OrderByDescending(e => e.EliminatedTime).Any(e => e.EliminatedTime == null))
                        {
                            Winner = CurrentGame.Contracts.OrderByDescending(e => e.EliminatedTime).First(e => e.EliminatedTime == null);
                            if (Winner.User_Id == contract.User_Id)
                                textBox_Winner.Text = contract.User.FirstName + " " + contract.User.LastName;
                        }
                        if (CurrentGame.Contracts.OrderByDescending(d => d.EliminatedTime).Any(e => e.EliminatedTime == null && e.User_Id != Winner.User_Id))
                        {
                            Second = CurrentGame.Contracts.OrderByDescending(d => d.EliminatedTime).First(e => e.EliminatedTime == null && e.User_Id != Winner.User_Id);
                            if (Second.User_Id == contract.User_Id)
                                textBox_Second.Text = contract.User.FirstName + " " + contract.User.LastName;
                        }
                        else
                        {
                            Second = CurrentGame.Contracts.OrderByDescending(d => d.EliminatedTime).First();
                            if (Second.User_Id == contract.User_Id)
                                textBox_Second.Text = contract.User.FirstName + " " + contract.User.LastName;
                        }
                        if (CurrentGame.Contracts.OrderByDescending(d => d.EliminatedTime).Any(e => e.User_Id != Winner.User_Id && e.User_Id != Second.User_Id))
                        {
                            Most = CurrentGame.Contracts.OrderByDescending(d => d.Eliminations).First(e => e.User_Id != Winner.User_Id && e.User_Id != Second.User_Id);
                            if (Most.User_Id == contract.User_Id)
                                textBox_Most.Text = contract.User.FirstName + " " + contract.User.LastName;
                        }
                    }
                }

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_gameUsers);
                row.Cells[0].Value = contract.User_Id;
                row.Cells[1].Value = contract.User.FirstName + " " + contract.User.LastName;
                if (contract.Word_Id !=null)
                {

                }
                if (contract.EliminatedTime != null)
                {
                    row.Cells[3].Value = "killed";
                }

                dataGridView_gameUsers.Rows.Add(row);
                
            }
            return CurrentGame;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            Game_Overview uc = new Game_Overview();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
