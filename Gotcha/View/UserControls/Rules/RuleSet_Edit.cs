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

namespace Gotcha.View.UserControls.Rules
{
    public partial class RuleSet_Edit : UserControl
    {
        private RuleController _RulezController = new RuleController();
        private Guid _RuleSet_id;

        public RuleSet_Edit(Guid RuleSet_Id)
        {
            InitializeComponent();
            _RuleSet_id = RuleSet_Id;

            RuleSet Ruleset = _RulezController.GetRuleSetById(_RuleSet_id);
            textBox_Name.Text = Ruleset.Name;

            FillGridDataAndTextBox(Ruleset);
            FillComboboxData();


        }

        private void FillComboboxData()
        {
            //fills the comboboxes with the correct data
            comboBox_Rule.DataSource = _RulezController.GetAllRules();

            comboBox_Rule.DisplayMember = "Name";
            comboBox_Rule.ValueMember = "Id";
        }

        private void FillGridDataAndTextBox(RuleSet Ruleset)
        {
            dataGridView_Rule.Rows.Clear();
            dataGridView_Rule.Refresh();

            foreach (var RuleRuleset in Ruleset.RuleRuleSet)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_Rule);

                row.Cells[0].Value = RuleRuleset.Rule_Id;
                row.Cells[1].Value = RuleRuleset.Rule.Name;
                dataGridView_Rule.Rows.Add(row);
            }
        }

        private void Btn_UpdateRuleSet_Click(object sender, EventArgs e)
        {
            string Name = textBox_Name.Text;
            if (_RulezController.UpdateRuleSet(Name, _RuleSet_id))
            {
                MessageBox.Show("you have Updated RuleSet");
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
            Rules_Overview uc = new Rules_Overview();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void Btn_AddRule_Click(object sender, EventArgs e)
        {
            Guid Rule_Id = Guid.Parse(comboBox_Rule.SelectedValue.ToString());

            if (_RulezController.AddRuleRuleSet(Rule_Id, _RuleSet_id))
            {
                MessageBox.Show("you have Add a Rule to Ruleset");

                //this wil reload the datagridview 
                RuleSet Ruleset = _RulezController.GetRuleSetById(_RuleSet_id);
                FillGridDataAndTextBox(Ruleset);
            }
            else
            {
                MessageBox.Show("Something when wrong please try again!! ");
            }
        }

        private void dataGridView_Rule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid Rule_id = Guid.Parse(dataGridView_Rule.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_Rule.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (_RulezController.DeleteRuleRuleSet(Rule_id, _RuleSet_id))
                {
                    MessageBox.Show("you have deleted a Ruleset");

                    //this wil reload the datagridview 
                    RuleSet Ruleset = _RulezController.GetRuleSetById(_RuleSet_id);
                    FillGridDataAndTextBox(Ruleset);
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }
    }
}
