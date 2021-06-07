using Gotcha.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotcha.View.UserControls.GameTypes
{
    public partial class GameType_Overview : UserControl
    {
        private GameTypeController _GameTypeController = new GameTypeController();
        public GameType_Overview()
        {
            InitializeComponent();
            FillOverview(_GameTypeController.GetAllGameTypes());
        }
        private void FillOverview(List<Models.GameType> ContentSet)
        {
            foreach (var _Rulez in ContentSet)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_GameType);

                row.Cells[0].Value = _Rulez.Id;
                row.Cells[1].Value = _Rulez.Name;
                row.Cells[2].Value = _Rulez.User.FirstName + " " + _Rulez.User.LastName;
                dataGridView_GameType.Rows.Add(row);
            }
        }

        private void dataGridView_GameType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid GameType_id = Guid.Parse(dataGridView_GameType.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_GameType.Columns[e.ColumnIndex].Name == "RuleSetRead")
            {
                //this.Controls.Clear();
                //Game_Edit uc = new Game_Edit(Game_id);
                //uc.Dock = DockStyle.Fill;
                //this.Controls.Add(uc);
            }
            if (dataGridView_GameType.Columns[e.ColumnIndex].Name == "RuleSetEdit")
            {
                this.Controls.Clear();
                GameType_Edit uc = new GameType_Edit(GameType_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_GameType.Columns[e.ColumnIndex].Name == "RuleSetDelete")
            {
                if (_GameTypeController.DeleteGameType(GameType_id))
                {
                    MessageBox.Show("you have deleted a Rulesset");
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }

        private void button_CreateGameType_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            GameType_Create uc = new GameType_Create();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
