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
    public partial class Word_Create : UserControl
    {
        private WordController _WordzController = new WordController();

        public Word_Create()
        {
            InitializeComponent();
        }

        private void Btn_CreateWord_Click(object sender, EventArgs e)
        {
            string word = textBox_Content.Text;
            if (_WordzController.AddWord(word))
            {
                MessageBox.Show("you have added a word");
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
