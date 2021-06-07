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
    public partial class Word_Edit : UserControl
    {
        private WordController _WordzController = new WordController();
        private Guid Word_id;

        public Word_Edit(Guid Id)
        {
            InitializeComponent();
            Word_id = Id;
            textBox_Content.Text = _WordzController.GetWordById(Word_id);

        }

        private void Btn_UpdateWord_Click(object sender, EventArgs e)
        {
            string word = textBox_Content.Text;
            if (_WordzController.UpdateWord(word, Word_id))
            {
                MessageBox.Show("you have Updated a word");
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
            Worden_Overview uc = new Worden_Overview();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}
