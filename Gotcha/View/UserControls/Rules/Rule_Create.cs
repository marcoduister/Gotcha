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

namespace Gotcha.View.UserControls.Rule
{
    public partial class Rule_Create : UserControl
    {
        private RuleController _RulezController = new RuleController();

        public Rule_Create()
        {
            InitializeComponent();
        }

        private void Btn_CreateRule_Click(object sender, EventArgs e)
        {
            string Rule = textBox_Name.Text;
            string Description = textBox_Description.Text;
            if (_RulezController.AddRule(Rule, Description))
            {
                MessageBox.Show("you have added a Rule");
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
