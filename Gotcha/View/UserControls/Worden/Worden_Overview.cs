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
    public partial class Worden_Overview : UserControl
    {
        private WordController _WordzController = new WordController();

        public Worden_Overview()
        {
            InitializeComponent();

            FillOverviewWordSet(_WordzController.GetAllWordSets());
            FillOverviewWord(_WordzController.GetAllWords());

        }
        private void FillOverviewWordSet(List<WordSet> ContentSet)
        {
            foreach (var _wordz in ContentSet)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_Wordset);

                row.Cells[0].Value = _wordz.Id;
                row.Cells[1].Value = _wordz.Name;
                row.Cells[2].Value = _wordz.User.FirstName+" "+ _wordz.User.LastName;

                dataGridView_Wordset.Rows.Add(row);
            }
        }
        private void FillOverviewWord(List<Word> ContentSet)
        {
            foreach (var _wordz in ContentSet)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_Wordset);

                row.Cells[0].Value = _wordz.Id;
                row.Cells[1].Value = _wordz.Content;
                row.Cells[2].Value = _wordz.User.FirstName + " " + _wordz.User.LastName;
                dataGridView_Worden.Rows.Add(row);
            }
        }


        private void button_CreateWorden_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Word_Create uc = new Word_Create();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void button_CreateWordSet_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            WordSet_Create uc = new WordSet_Create();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void dataGridView_Wordset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid wordSet_id = Guid.Parse(dataGridView_Wordset.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_Wordset.Columns[e.ColumnIndex].Name == "WordSetRead")
            {
                //this.Controls.Clear();
                //Game_Edit uc = new Game_Edit(Game_id);
                //uc.Dock = DockStyle.Fill;
                //this.Controls.Add(uc);
            }
            if (dataGridView_Wordset.Columns[e.ColumnIndex].Name == "WordSetEdit")
            {
                this.Controls.Clear();
                WordSet_Edit uc = new WordSet_Edit(wordSet_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_Wordset.Columns[e.ColumnIndex].Name == "WordSetDelete")
            {
                if (_WordzController.DeleteWordSet(wordSet_id))
                {
                    MessageBox.Show("you have deleted a wordset");
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }

        private void dataGridView_Worden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid word_id = Guid.Parse(dataGridView_Worden.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_Worden.Columns[e.ColumnIndex].Name == "WordRead")
            {
                //this.Controls.Clear();
                //Game_Edit uc = new Game_Edit(Game_id);
                //uc.Dock = DockStyle.Fill;
                //this.Controls.Add(uc);
            }
            if (dataGridView_Worden.Columns[e.ColumnIndex].Name == "WordEdit")
            {
                this.Controls.Clear();
                Word_Edit uc = new Word_Edit(word_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_Worden.Columns[e.ColumnIndex].Name == "WordDelete")
            {
                if (_WordzController.DeleteWord(word_id))
                {
                    MessageBox.Show("you have deleted word");
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }
    }
}
