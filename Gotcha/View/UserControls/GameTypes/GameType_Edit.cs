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
    public partial class GameType_Edit : UserControl
    {
        private GameTypeController _GameTypeController = new GameTypeController();
        private Guid _GameType_id;
        public GameType_Edit(Guid GameType_id)
        {
            InitializeComponent();
            _GameType_id = GameType_id;
            Models.GameType GameType = _GameTypeController.GetGameTypeById(_GameType_id);
            textBox_Name.Text = GameType.Name;
            textBox_Description.Text = GameType.Description;
        }

        private void Btn_UpdateGameType_Click(object sender, EventArgs e)
        {
            string Name = textBox_Name.Text;
            string Description = textBox_Description.Text;
            if (_GameTypeController.UpdateGameType(Name, Description, _GameType_id))
            {
                MessageBox.Show("you have Updated a GameType");
            }
            else
            {
                MessageBox.Show("Something when wrong please try again!! ");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
