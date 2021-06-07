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

            WordSet wordset = _WordzController.GetWordSetById(_WordSet_id);
            textBox_Name.Text = wordset.Name;

            FillGridDataAndTextBox(wordset);
            FillComboboxData();


        }

        private void FillComboboxData()
        {
            //fills the comboboxes with the correct data
            comboBox_Word.DataSource = _WordzController.GetAllWords();

            comboBox_Word.DisplayMember = "Content";
            comboBox_Word.ValueMember = "Id";
        }

        private void FillGridDataAndTextBox(WordSet wordset)
        {
            dataGridView_worden.Rows.Clear();
            dataGridView_worden.Refresh();

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
            string Name = textBox_Name.Text;
            if (_WordzController.UpdateWordSet(Name,_WordSet_id))
            {
                MessageBox.Show("you have Updated WordSet");
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

        private void Btn_AddWord_Click(object sender, EventArgs e)
        {
            Guid Word_Id = Guid.Parse(comboBox_Word.SelectedValue.ToString());

            if (_WordzController.AddWordWordSet(Word_Id, _WordSet_id))
            {
                MessageBox.Show("you have Add a word to Wordset");

                //this wil reload the datagridview 
                WordSet wordset = _WordzController.GetWordSetById(_WordSet_id);
                FillGridDataAndTextBox(wordset);
            }
            else
            {
                MessageBox.Show("Something when wrong please try again!! ");
            }
        }
        
        private void dataGridView_worden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid word_id = Guid.Parse(dataGridView_worden.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_worden.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (_WordzController.DeleteWordWordSet(word_id,_WordSet_id))
                {
                    MessageBox.Show("you have deleted a wordset");

                    //this wil reload the datagridview 
                    WordSet wordset = _WordzController.GetWordSetById(_WordSet_id);
                    FillGridDataAndTextBox(wordset);
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }
    }
}
