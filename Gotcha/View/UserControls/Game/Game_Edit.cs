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
    public partial class Game_Edit : UserControl
    {
        private GameController _GameController = new GameController();
        private Guid _Game_Id;

        public Game_Edit(Guid Game_Id)
        {
            InitializeComponent();
            _Game_Id = Game_Id;

            Models.Game CurrentGame = _GameController.GetGameById(Game_Id);

            textBox_Name.Text = CurrentGame.Name;
            textBox_Location.Text = CurrentGame.Location;
            textBoxActivePlayer.Text = CurrentGame.Contracts.Count().ToString();
            textBox_Game_id.Text = CurrentGame.Id.ToString();
            if (CurrentGame.StartTime != null)
            {
                Btn_archiveGame.Visible = true;
            }

            FillComboboxData(CurrentGame);
            Filldatagridview(CurrentGame);



        }

        private void Filldatagridview(Models.Game CurrentGame)
        {
            dataGridView_gameUsers.Rows.Clear();
            // this will fill the contract list and wil fill the win textboxes
            foreach (var contract in CurrentGame.Contracts)
            {
                Contract Winner = null;
                Contract Second = null;
                Contract Most = null;
                if (CurrentGame.Contracts.Any(e => e.EliminatedTime != null))
                {
                     Winner = CurrentGame.Contracts.OrderByDescending(e => e.EliminatedTime).First(e =>e.EliminatedTime == null);
                     Second = CurrentGame.Contracts.OrderByDescending(d => d.EliminatedTime).First(e => e.EliminatedTime == null && e.User_Id != Winner.User_Id);
                     Most = CurrentGame.Contracts.OrderByDescending(d => d.Eliminations).First(e => e.User_Id != Winner.User_Id && e.User_Id != Second.User_Id);

                    if (Winner.User_Id == contract.User_Id)
                    {
                        textBox_Winner.Text = contract.User.FirstName + " " + contract.User.LastName;
                    }
                    if (Second.User_Id == contract.User_Id)
                    {
                        textBox_Second.Text = contract.User.FirstName + " " + contract.User.LastName;
                    }
                    if (Most.User_Id == contract.User_Id)
                    {
                        textBox_Most.Text = contract.User.FirstName + " " + contract.User.LastName;
                    }
                }
               
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_gameUsers);
                row.Cells[0].Value = contract.User_Id;
                row.Cells[1].Value = contract.User.FirstName + " " + contract.User.LastName;

                if (CurrentGame.Contracts.Count(e => e.EliminatedTime == null) >= 1)
                {
                    if (contract.EliminatedTime == null)
                    {
                        DataGridViewButtonCell btn_Kill = new DataGridViewButtonCell() { Value = "Kill" };
                        row.Cells[2] = btn_Kill;
                    }
                }

                dataGridView_gameUsers.Rows.Add(row);
            }
        }

        private void FillComboboxData(Models.Game CurrentGame) 
        {
            var results = _GameController.GetGameComboLists();

            //fills the comboboxes with the correct data
            comboBox_User.DataSource = _GameController.GetUsers().Select(e => new { Value = e.Id, Text = e.FirstName + " " + e.LastName }).ToList();
            comboBox_WordSet.DataSource = results.Item1.Select(e => new { Value = e.Id, Text = e.Name }).ToList();
            comboBox_GameType.DataSource = results.Item2.Select(e => new { Value = e.Id, Text = e.Name }).ToList();
            comboBox_RuleSet.DataSource = results.Item3.Select(e => new { Value = e.Id, Text = e.Name }).ToList();
            comboBox_Random.DataSource = CurrentGame.Contracts.Select(e => new { Value = e.User_Id, Text = e.User.FirstName +" "+e.User.LastName }).ToList();
            comboBox_best.DataSource = CurrentGame.Contracts.Select(e => new { Value = e.User_Id, Text = e.User.FirstName + " " + e.User.LastName }).ToList();

            comboBox_GameType.ValueMember = comboBox_RuleSet.ValueMember = comboBox_User.ValueMember = 
                comboBox_WordSet.ValueMember = comboBox_best.ValueMember = comboBox_Random.ValueMember = "Value";
            comboBox_GameType.DisplayMember = comboBox_RuleSet.DisplayMember = comboBox_User.DisplayMember = 
                comboBox_WordSet.DisplayMember =comboBox_best.DisplayMember = comboBox_Random.DisplayMember = "Text";


            // select the object from currentgame that is selected
            comboBox_WordSet.SelectedIndex = results.Item1.FindIndex(w => w.Id == CurrentGame.WordSet_Id);
            comboBox_GameType.SelectedIndex = results.Item2.FindIndex(w => w.Id == CurrentGame.GameType_Id);
            comboBox_RuleSet.SelectedIndex = results.Item3.FindIndex(w => w.Id == CurrentGame.RuleSet_Id);
            comboBox_best.SelectedIndex = CurrentGame.Contracts.FindIndex(w => w.User_Id == CurrentGame.BestKill);
            comboBox_Random.SelectedIndex = CurrentGame.Contracts.FindIndex(w => w.User_Id == CurrentGame.RandomWiner);
        }

        private void Btn_UpdateGame_Click(object sender, EventArgs e)
        {

            Models.Game game = new Models.Game()
            {
                Id = _Game_Id,
                Name = textBox_Name.Text,
                Location = textBox_Location.Text,
            };

            if (comboBox_GameType.SelectedValue != null)
            {
                game.GameType_Id = new Guid(comboBox_GameType.SelectedValue.ToString());
            }
            if (comboBox_RuleSet.SelectedValue != null)
            {
                game.RuleSet_Id = new Guid(comboBox_RuleSet.SelectedValue.ToString());
            }
            if (comboBox_WordSet.SelectedValue != null)
            {
                game.WordSet_Id = new Guid(comboBox_WordSet.SelectedValue.ToString());
            }
            if (comboBox_best.SelectedValue != null)
            {
                game.BestKill = new Guid(comboBox_best.SelectedValue.ToString());
            }
            if (comboBox_Random.SelectedValue != null)
            {
                game.RandomWiner = new Guid(comboBox_Random.SelectedValue.ToString());
            }
            if (_GameController.Edit(game))
            {
                MessageBox.Show("you have Updated a Game ");
                Btn_Cancel_Click(null, null);
            }
            else
            {
                MessageBox.Show("Something when wrong please try again!! ");
            }

        }

        private void Btn_addUser_Click(object sender, EventArgs e)
        {
            string User_Id = comboBox_User.SelectedValue.ToString();
            string Game_id = textBox_Game_id.Text;
            if (_GameController.AddContractUser(new Guid(User_Id),new Guid(Game_id)))
            {
                MessageBox.Show("you have added a User to Contracts");
                Models.Game CurrentGame = _GameController.GetGameById(_Game_Id);
                Filldatagridview(CurrentGame);
            }
            else
            {
                MessageBox.Show("Something when wrong please try again!! ");
            }
            
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Game_Overview uc = new Game_Overview();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void dataGridView_gameUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid User_id = Guid.Parse(dataGridView_gameUsers.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_gameUsers.Columns[e.ColumnIndex].Name == "btn_Delete")
            {
                if (_GameController.DeleteContract(User_id,_Game_Id))
                {
                    MessageBox.Show("you have deleted a User from contracts");

                    //this wil reload the datagridview 
                    Models.Game CurrentGame = _GameController.GetGameById(_Game_Id);
                    Filldatagridview(CurrentGame);
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
            if (dataGridView_gameUsers.Columns[e.ColumnIndex].Name == "btn_Kill")
            {
                if (_GameController.KillContract(User_id, _Game_Id))
                {
                    MessageBox.Show("you have Killed a User");

                    //this wil reload the datagridview 
                    Models.Game CurrentGame = _GameController.GetGameById(_Game_Id);
                    Filldatagridview(CurrentGame);
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }

        private void Btn_archiveGame_Click(object sender, EventArgs e)
        {
            if (_GameController.Archiving(_Game_Id))
            {
                MessageBox.Show("you have Archived this Game");
                Btn_Cancel_Click(null,null);
            }
            else
            {
                MessageBox.Show("Something when wrong please try again!! ");
            }
        }
    }
}
