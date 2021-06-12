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

            Models.Game CurrentGame = Filldatagridview();

            FillComboboxData(CurrentGame);

            textBox_Name.Text = CurrentGame.Name;
            textBox_Location.Text = CurrentGame.Location;
            textBoxActivePlayer.Text = CurrentGame.Contracts.Count().ToString();
            textBox_Game_id.Text = CurrentGame.Id.ToString();
            if (CurrentGame.StartTime != null)
            {
                Btn_archiveGame.Visible = true;
                Btn_addUser.Visible = false;
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
                if (contract.Word_Id != null)

                if (CurrentGame.Contracts.Count(e => e.EliminatedTime == null) >= 2)
                {
                    if (contract.EliminatedTime == null && CurrentGame.StartTime != null)
                    {
                        DataGridViewButtonCell btn_Kill = new DataGridViewButtonCell() { Value = "Kill" };
                        row.Cells[3] = btn_Kill;
                    }
                }
                if (CurrentGame.StartTime == null)
                {
                    DataGridViewButtonCell btn_Delete = new DataGridViewButtonCell() { Value = "Delete" };
                    row.Cells[4] = btn_Delete;
                }
                else
                {
                    {
                        row.Cells[2].Value = CurrentGame.WordSet.WordWordset.Where(e => e.Word_Id == contract.Word_Id).First().Word.Content;

                    }
                }
                if (contract.EliminatedTime != null)
                {
                    row.Cells[3].Value = "killed";
                }

                dataGridView_gameUsers.Rows.Add(row);
                
            }
            return CurrentGame;
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
            Models.Game CurrentGame =  _GameController.GetGameBy(_Game_Id);

            if (CurrentGame.StartTime != null && (Enums.Rolen)Properties.Settings.Default.UserRol == Enums.Rolen.Gamemaster)
            {
                if (comboBox_best.SelectedValue != null)
                {
                    CurrentGame.BestKill = new Guid(comboBox_best.SelectedValue.ToString());
                }
                if (comboBox_Random.SelectedValue != null)
                {
                    CurrentGame.RandomWiner = new Guid(comboBox_Random.SelectedValue.ToString());
                }
            }
            else
            {
                CurrentGame.Name = textBox_Name.Text;
                CurrentGame.Location = textBox_Location.Text;
                if (comboBox_GameType.SelectedValue != null)
                {
                    CurrentGame.GameType_Id = new Guid(comboBox_GameType.SelectedValue.ToString());
                }
                if (comboBox_RuleSet.SelectedValue != null)
                {
                    CurrentGame.RuleSet_Id = new Guid(comboBox_RuleSet.SelectedValue.ToString());
                }
                if (comboBox_WordSet.SelectedValue != null)
                {
                    CurrentGame.WordSet_Id = new Guid(comboBox_WordSet.SelectedValue.ToString());
                }
                if (CurrentGame.StartTime != null)
                {
                    if (comboBox_best.SelectedValue != null)
                    {
                        CurrentGame.BestKill = new Guid(comboBox_best.SelectedValue.ToString());
                    }
                    if (comboBox_Random.SelectedValue != null)
                    {
                        CurrentGame.RandomWiner = new Guid(comboBox_Random.SelectedValue.ToString());
                    }
                }
            }

            if (_GameController.Edit(CurrentGame))
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
                //Models.Game CurrentGame = _GameController.GetGameById(_Game_Id);
                Filldatagridview();
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
                    Filldatagridview();
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
                    
                    Filldatagridview();
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
