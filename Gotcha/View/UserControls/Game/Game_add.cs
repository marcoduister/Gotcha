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
            FillComboboxData();

        }
        private void FillComboboxData()
        {
            var results = _GameController.GetGameComboLists();

            //fills the comboboxes with the correct data
            var Worden = results.Item1.Select(e => new { Value = e.Id, Text = e.Name }).ToList();
            Worden.Insert(0, new { Value = Guid.Empty, Text = "--Select--" });
            var GameType = results.Item2.Select(e => new { Value = e.Id, Text = e.Name }).ToList();
            GameType.Insert(0, new { Value = Guid.Empty, Text = "--Select--" });
            var Ruleset = results.Item3.Select(e => new { Value = e.Id, Text = e.Name }).ToList();
            Ruleset.Insert(0, new { Value = Guid.Empty, Text = "--Select--" });
            comboBox_WordSet.DataSource = Worden;
            comboBox_GameType.DataSource = GameType;
            comboBox_RuleSet.DataSource = Ruleset;


            comboBox_GameType.ValueMember = comboBox_RuleSet.ValueMember = comboBox_WordSet.ValueMember = "Value";
            comboBox_GameType.DisplayMember = comboBox_RuleSet.DisplayMember = comboBox_WordSet.DisplayMember = "Text";
        }

        private void Btn_CreateGame_Click(object sender, EventArgs e)
        {
            Models.Game game = new Models.Game()
            {
                Name = textBox_Name.Text,
                Location = textBox_Location.Text
            };
            if (new Guid(comboBox_GameType.SelectedValue.ToString()) != Guid.Empty)
            {
                game.GameType_Id = new Guid(comboBox_GameType.SelectedValue.ToString());
            }
            if (new Guid(comboBox_RuleSet.SelectedValue.ToString()) != Guid.Empty)
            {
                game.RuleSet_Id = new Guid(comboBox_RuleSet.SelectedValue.ToString());
            }
            if (new Guid(comboBox_WordSet.SelectedValue.ToString()) != Guid.Empty)
            {
                game.WordSet_Id = new Guid(comboBox_WordSet.SelectedValue.ToString());
            }
            if (_GameController.AddGame(game))
            {
                MessageBox.Show("you have created a Game");
                Btn_Cancel_Click(null, null);
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
    }
}
