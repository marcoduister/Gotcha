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
    public partial class RuleSet_Read : UserControl
    {
        private RuleController _RulezController = new RuleController();
        private Guid _RuleSet_id;
        public RuleSet_Read(Guid RuleSet_Id)
        {
            InitializeComponent();
            _RuleSet_id = RuleSet_Id;

            RuleSet Ruleset = _RulezController.GetRuleSetById(_RuleSet_id);

            FillGridDataAndTextBox(Ruleset);
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
    }
}
