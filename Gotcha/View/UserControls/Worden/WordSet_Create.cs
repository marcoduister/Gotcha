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

namespace Gotcha.View.UserControls.Worden
{
    public partial class WordSet_Create : UserControl
    {
        private WordController _WordzController = new WordController();
        public WordSet_Create()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CreateWordSet_Click(object sender, EventArgs e)
        {
            string WordSetName = textBox_Name.Text;
            if (_WordzController.AddWordSet(WordSetName))
            {
                MessageBox.Show("you have Created a wordset go To edit to add Words");
            }
            else
            {
                MessageBox.Show("Something when wrong please try again!! ");
            }
        }
    }
}
