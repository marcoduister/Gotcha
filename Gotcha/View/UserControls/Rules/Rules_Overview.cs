using Gotcha.BUS;
using Gotcha.Models;
using Gotcha.View.UserControls.Rule;
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
    public partial class Rules_Overview : UserControl
    {
        private RuleController _RulezController = new RuleController();

        public Rules_Overview()
        {
            InitializeComponent();

            FillOverviewRuleSet(_RulezController.GetAllRuleSets());
            FillOverviewRule(_RulezController.GetAllRules());

        }
        private void FillOverviewRuleSet(List<RuleSet> ContentSet)
        {
            foreach (var _Rulez in ContentSet)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_RuleSet);

                row.Cells[0].Value = _Rulez.Id;
                row.Cells[1].Value = _Rulez.Name;
                row.Cells[2].Value = _Rulez.User.FirstName + " " + _Rulez.User.LastName;

                dataGridView_RuleSet.Rows.Add(row);
            }
        }
        private void FillOverviewRule(List<Models.Rule> ContentSet)
        {
            foreach (var _Rulez in ContentSet)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_Rule);

                row.Cells[0].Value = _Rulez.Id;
                row.Cells[1].Value = _Rulez.Name;
                row.Cells[2].Value = _Rulez.User.FirstName + " " + _Rulez.User.LastName;
                dataGridView_Rule.Rows.Add(row);
            }
        }
        
        private void button_CreateRule_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Rule_Create uc = new Rule_Create();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void button_CreateRuleSet_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            RuleSet_Create uc = new RuleSet_Create();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void dataGridView_RuleSet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid RuleSet_id = Guid.Parse(dataGridView_RuleSet.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_RuleSet.Columns[e.ColumnIndex].Name == "RuleSetRead")
            {
                this.Controls.Clear();
                RuleSet_Read uc = new RuleSet_Read(RuleSet_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_RuleSet.Columns[e.ColumnIndex].Name == "RuleSetEdit")
            {
                this.Controls.Clear();
                RuleSet_Edit uc = new RuleSet_Edit(RuleSet_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_RuleSet.Columns[e.ColumnIndex].Name == "RuleSetDelete")
            {
                if (_RulezController.DeleteRuleSet(RuleSet_id))
                {
                    MessageBox.Show("you have deleted a Rulesset");
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }

        private void dataGridView_Rule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid Rule_id = Guid.Parse(dataGridView_Rule.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dataGridView_Rule.Columns[e.ColumnIndex].Name == "RuleRead")
            {
                var rule = _RulezController.GetRuleById(Rule_id);
                MessageBox.Show($"Rule name: {rule.Name} Description: {rule.Description}");
            }
            if (dataGridView_Rule.Columns[e.ColumnIndex].Name == "RuleEdit")
            {
                this.Controls.Clear();
                Rule_Edit uc = new Rule_Edit(Rule_id);
                uc.Dock = DockStyle.Fill;
                this.Controls.Add(uc);
            }
            if (dataGridView_Rule.Columns[e.ColumnIndex].Name == "RuleDelete")
            {
                if (_RulezController.DeleteRule(Rule_id))
                {
                    MessageBox.Show("you have deleted Rules");
                }
                else
                {
                    MessageBox.Show("Something when wrong please try again!! ");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
