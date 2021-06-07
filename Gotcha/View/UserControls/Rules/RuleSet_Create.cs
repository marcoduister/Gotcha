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

namespace Gotcha.View.UserControls.Rules
{
    public partial class RuleSet_Create : UserControl
    {
        private RuleController _RulezController = new RuleController();
        public RuleSet_Create()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Rules_Overview uc = new Rules_Overview();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void Btn_CreateRuleSet_Click(object sender, EventArgs e)
        {
            string RuleSetName = textBox_Name.Text;
            if (_RulezController.AddRuleSet(RuleSetName))
            {
                MessageBox.Show("you have Created a RuleSet go To edit to add Rules");
                Btn_Cancel_Click(null, null);
            }
            else
            {
                MessageBox.Show("Something when wrong please try again!! ");
            }
        }
    }
}
