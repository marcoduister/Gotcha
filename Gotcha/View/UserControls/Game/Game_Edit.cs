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

            FillComboboxData(CurrentGame);
            Filldatagridview(CurrentGame);

            textBox_Name.Text = CurrentGame.Name;
            textBox_Location.Text = CurrentGame.Location;
            textBoxActivePlayer.Text = CurrentGame.Contracts.Count().ToString();
            textBox_Game_id.Text = CurrentGame.Id.ToString();
        }

        private void Filldatagridview(Models.Game CurrentGame)
        {
            dataGridView_gameUsers.Rows.Clear();
            // this will fill the contract list and wil fill the win textboxes
            foreach (var contract in CurrentGame.Contracts)
            {
                
                int mostkill = CurrentGame.Contracts.Max(w => w.Eliminations);
                if (contract.Eliminations == mostkill)
                {
                    textBox_Most.Text = contract.User.FirstName + " " + contract.User.LastName;
                }

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_gameUsers);
                row.Cells[0].Value = contract.Id;
                row.Cells[1].Value = contract.User.FirstName + " " + contract.User.LastName;
                dataGridView_gameUsers.Rows.Add(row);
            }
        }

        private void FillComboboxData(Models.Game CurrentGame) 
        {
            var results = _GameController.GetGameComboLists();

            //fills the comboboxes with the correct data
            comboBox_User.DataSource = _GameController.GetUsers();
            comboBox_WordSet.DataSource = results.Item1;
            comboBox_GameType.DataSource = results.Item2;
            comboBox_RuleSet.DataSource = results.Item3;

            comboBox_GameType.DisplayMember = comboBox_RuleSet.DisplayMember = comboBox_WordSet.DisplayMember = "Name";
            comboBox_GameType.ValueMember = comboBox_RuleSet.ValueMember = comboBox_User.ValueMember = comboBox_WordSet.ValueMember = "Id";
            comboBox_User.DisplayMember = "FirstName";

            // select the object from currentgame that is selected
            comboBox_WordSet.SelectedIndex = results.Item1.FindIndex(w => w.Id == CurrentGame.WordSet_Id);
            comboBox_GameType.SelectedIndex = results.Item2.FindIndex(w => w.Id == CurrentGame.GameType_Id);
            comboBox_RuleSet.SelectedIndex = results.Item3.FindIndex(w => w.Id == CurrentGame.RuleSet_Id);
        }

        private void Btn_UpdateGame_Click(object sender, EventArgs e)
        {
            Models.Game game = new Models.Game()
            {
                Name = textBox_Name.Text,
                Location = textBox_Location.Text,
                StartTime = dateTimePicker_Start.Value,
                EindTime = dateTimePicker_End.Value
            };
            _GameController.Edit(game);
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
    }
}
