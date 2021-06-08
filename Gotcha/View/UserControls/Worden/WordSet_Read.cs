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
    public partial class WordSet_Read : UserControl
    {
        private WordController _WordzController = new WordController();
        private Guid _WordSet_id;

        public WordSet_Read(Guid WordSet_Id)
        {
            InitializeComponent();
            _WordSet_id = WordSet_Id;

            WordSet wordset = _WordzController.GetWordSetById(_WordSet_id);

            FillGridDataAndTextBox(wordset);
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
    }
}
