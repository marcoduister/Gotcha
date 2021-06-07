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
    public partial class GameType_Create : UserControl
    {
        private GameTypeController _GameTypeController = new GameTypeController();
        public GameType_Create()
        {
            InitializeComponent();
        }

        private void Btn_CreateGameType_Click(object sender, EventArgs e)
        {
            string Name = textBox_Name.Text;
            string Description = textBox_Description.Text;
            if (_GameTypeController.AddGameType(Name, Description))
            {
                MessageBox.Show("you have added a GameType");
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
