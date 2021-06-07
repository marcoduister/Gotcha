using Gotcha.BUS;
using System;
using Gotcha.Models;
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
    public partial class Rule_Edit : UserControl
    {
        private RuleController _RulezController = new RuleController();
        private Guid Rule_id;

        public Rule_Edit(Guid Id)
        {
            InitializeComponent();
            Rule_id = Id;
            Models.Rule Rule =_RulezController.GetRuleById(Rule_id);
            textBox_Name.Text = Rule.Name;
            textBox_Description.Text = Rule.Description;

        }

        private void Btn_UpdateRule_Click(object sender, EventArgs e)
        {
            string Rule = textBox_Name.Text;
            string Description = textBox_Description.Text;
            if (_RulezController.UpdateRule(Rule , Description, Rule_id))
            {
                MessageBox.Show("you have Updated a Rule");
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
    }
}
