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

namespace Gotcha.View.UserControls.Worden
{
    public partial class WordSet_Edit : UserControl
    {
        private WordController _WordzController = new WordController();
        private Guid _WordSet_id;

        public WordSet_Edit(Guid WordSet_Id)
        {
            InitializeComponent();
            _WordSet_id = WordSet_Id;

            FillGridDataAndTextBox();
            FillComboboxData();


        }

        private void FillComboboxData()
        {
            //fills the comboboxes with the correct data
            comboBox_Word.DataSource = _WordzController.GetAllWords();

            comboBox_Word.DisplayMember = "Content";
            comboBox_Word.ValueMember = "Id";
        }
        private void FillGridDataAndTextBox()
        {
            WordSet wordset = _WordzController.GetWordSetById(_WordSet_id);
            textBox_Name.Text = wordset.Name;

            foreach (var wordWordset in wordset.WordWordset)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_worden);

                row.Cells[0].Value = wordWordset.Word_Id;
                row.Cells[1].Value = wordWordset.Word.Content;
                dataGridView_worden.Rows.Add(row);
            }
        }

        private void Btn_UpdateWordSet_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AddWord_Click(object sender, EventArgs e)
        {

        }
    }
}
