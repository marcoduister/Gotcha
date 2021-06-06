
namespace Gotcha.View.UserControls.Rules
{
    partial class Rules_Overview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RuleSetEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateRuleSet = new System.Windows.Forms.Button();
            this.dataGridView_Rule = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RuleEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RuleDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RuleSetRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelRule = new System.Windows.Forms.Label();
            this.dataGridView_RuleSet = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleSetMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleSetDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_CreateRule = new System.Windows.Forms.Button();
            this.TabRule = new System.Windows.Forms.TabPage();
            this.TabRuleSet = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RuleSet)).BeginInit();
            this.TabRule.SuspendLayout();
            this.TabRuleSet.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // RuleSetEdit
            // 
            this.RuleSetEdit.HeaderText = "Edit";
            this.RuleSetEdit.MinimumWidth = 6;
            this.RuleSetEdit.Name = "RuleSetEdit";
            this.RuleSetEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RuleSetEdit.Text = "Edit";
            this.RuleSetEdit.UseColumnTextForButtonValue = true;
            this.RuleSetEdit.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "RuleSet Overview";
            // 
            // button_CreateRuleSet
            // 
            this.button_CreateRuleSet.Location = new System.Drawing.Point(51, 90);
            this.button_CreateRuleSet.Name = "button_CreateRuleSet";
            this.button_CreateRuleSet.Size = new System.Drawing.Size(75, 23);
            this.button_CreateRuleSet.TabIndex = 6;
            this.button_CreateRuleSet.Text = "Create";
            this.button_CreateRuleSet.UseVisualStyleBackColor = true;
            this.button_CreateRuleSet.Click += new System.EventHandler(this.button_CreateRuleSet_Click);
            // 
            // dataGridView_Rule
            // 
            this.dataGridView_Rule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.RuleName,
            this.RuleMaker,
            this.RuleRead,
            this.RuleEdit,
            this.RuleDelete});
            this.dataGridView_Rule.Location = new System.Drawing.Point(51, 131);
            this.dataGridView_Rule.Name = "dataGridView_Rule";
            this.dataGridView_Rule.RowHeadersWidth = 51;
            this.dataGridView_Rule.RowTemplate.Height = 24;
            this.dataGridView_Rule.Size = new System.Drawing.Size(803, 361);
            this.dataGridView_Rule.TabIndex = 5;
            this.dataGridView_Rule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Rule_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // RuleName
            // 
            this.RuleName.HeaderText = "Content";
            this.RuleName.MinimumWidth = 6;
            this.RuleName.Name = "RuleName";
            this.RuleName.Width = 125;
            // 
            // RuleMaker
            // 
            this.RuleMaker.HeaderText = "Maker";
            this.RuleMaker.MinimumWidth = 6;
            this.RuleMaker.Name = "RuleMaker";
            this.RuleMaker.Width = 125;
            // 
            // RuleRead
            // 
            this.RuleRead.HeaderText = "Read";
            this.RuleRead.MinimumWidth = 6;
            this.RuleRead.Name = "RuleRead";
            this.RuleRead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RuleRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RuleRead.Text = "Read";
            this.RuleRead.UseColumnTextForButtonValue = true;
            this.RuleRead.Width = 125;
            // 
            // RuleEdit
            // 
            this.RuleEdit.HeaderText = "Edit";
            this.RuleEdit.MinimumWidth = 6;
            this.RuleEdit.Name = "RuleEdit";
            this.RuleEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RuleEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RuleEdit.Text = "Edit";
            this.RuleEdit.UseColumnTextForButtonValue = true;
            this.RuleEdit.Width = 125;
            // 
            // RuleDelete
            // 
            this.RuleDelete.HeaderText = "Delete";
            this.RuleDelete.MinimumWidth = 6;
            this.RuleDelete.Name = "RuleDelete";
            this.RuleDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RuleDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RuleDelete.Text = "Delete";
            this.RuleDelete.UseColumnTextForButtonValue = true;
            this.RuleDelete.Width = 125;
            // 
            // RuleSetRead
            // 
            this.RuleSetRead.HeaderText = "Read";
            this.RuleSetRead.MinimumWidth = 6;
            this.RuleSetRead.Name = "RuleSetRead";
            this.RuleSetRead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RuleSetRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RuleSetRead.Text = "Read";
            this.RuleSetRead.UseColumnTextForButtonValue = true;
            this.RuleSetRead.Width = 125;
            // 
            // labelRule
            // 
            this.labelRule.AutoSize = true;
            this.labelRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule.Location = new System.Drawing.Point(45, 24);
            this.labelRule.Name = "labelRule";
            this.labelRule.Size = new System.Drawing.Size(199, 32);
            this.labelRule.TabIndex = 4;
            this.labelRule.Text = "Rule Overview";
            // 
            // dataGridView_RuleSet
            // 
            this.dataGridView_RuleSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RuleSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.RuleSetMaker,
            this.RuleSetRead,
            this.RuleSetEdit,
            this.RuleSetDelete});
            this.dataGridView_RuleSet.Location = new System.Drawing.Point(51, 131);
            this.dataGridView_RuleSet.Name = "dataGridView_RuleSet";
            this.dataGridView_RuleSet.RowHeadersWidth = 51;
            this.dataGridView_RuleSet.RowTemplate.Height = 24;
            this.dataGridView_RuleSet.Size = new System.Drawing.Size(803, 361);
            this.dataGridView_RuleSet.TabIndex = 5;
            this.dataGridView_RuleSet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RuleSet_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // RuleSetMaker
            // 
            this.RuleSetMaker.HeaderText = "Maker";
            this.RuleSetMaker.MinimumWidth = 6;
            this.RuleSetMaker.Name = "RuleSetMaker";
            this.RuleSetMaker.Width = 125;
            // 
            // RuleSetDelete
            // 
            this.RuleSetDelete.HeaderText = "Delete";
            this.RuleSetDelete.MinimumWidth = 6;
            this.RuleSetDelete.Name = "RuleSetDelete";
            this.RuleSetDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RuleSetDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RuleSetDelete.Text = "Delete";
            this.RuleSetDelete.UseColumnTextForButtonValue = true;
            this.RuleSetDelete.Width = 125;
            // 
            // button_CreateRule
            // 
            this.button_CreateRule.Location = new System.Drawing.Point(51, 90);
            this.button_CreateRule.Name = "button_CreateRule";
            this.button_CreateRule.Size = new System.Drawing.Size(75, 23);
            this.button_CreateRule.TabIndex = 6;
            this.button_CreateRule.Text = "Create";
            this.button_CreateRule.UseVisualStyleBackColor = true;
            this.button_CreateRule.Click += new System.EventHandler(this.button_CreateRule_Click);
            // 
            // TabRule
            // 
            this.TabRule.Controls.Add(this.dataGridView_Rule);
            this.TabRule.Controls.Add(this.labelRule);
            this.TabRule.Controls.Add(this.button_CreateRule);
            this.TabRule.Location = new System.Drawing.Point(4, 25);
            this.TabRule.Name = "TabRule";
            this.TabRule.Padding = new System.Windows.Forms.Padding(3);
            this.TabRule.Size = new System.Drawing.Size(899, 516);
            this.TabRule.TabIndex = 1;
            this.TabRule.Text = "Rule";
            this.TabRule.UseVisualStyleBackColor = true;
            // 
            // TabRuleSet
            // 
            this.TabRuleSet.Controls.Add(this.dataGridView_RuleSet);
            this.TabRuleSet.Controls.Add(this.label1);
            this.TabRuleSet.Controls.Add(this.button_CreateRuleSet);
            this.TabRuleSet.Location = new System.Drawing.Point(4, 25);
            this.TabRuleSet.Name = "TabRuleSet";
            this.TabRuleSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabRuleSet.Size = new System.Drawing.Size(899, 516);
            this.TabRuleSet.TabIndex = 0;
            this.TabRuleSet.Text = "RuleSet";
            this.TabRuleSet.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabRuleSet);
            this.TabControl.Controls.Add(this.TabRule);
            this.TabControl.Location = new System.Drawing.Point(2, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(907, 545);
            this.TabControl.TabIndex = 1;
            // 
            // Rules_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Size = new System.Drawing.Size(910, 545);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RuleSet)).EndInit();
            this.TabRule.ResumeLayout(false);
            this.TabRule.PerformLayout();
            this.TabRuleSet.ResumeLayout(false);
            this.TabRuleSet.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn RuleSetEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CreateRuleSet;
        private System.Windows.Forms.DataGridView dataGridView_Rule;
        private System.Windows.Forms.DataGridViewButtonColumn RuleSetRead;
        private System.Windows.Forms.Label labelRule;
        private System.Windows.Forms.DataGridView dataGridView_RuleSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleSetMaker;
        private System.Windows.Forms.DataGridViewButtonColumn RuleSetDelete;
        private System.Windows.Forms.Button button_CreateRule;
        private System.Windows.Forms.TabPage TabRule;
        private System.Windows.Forms.TabPage TabRuleSet;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleMaker;
        private System.Windows.Forms.DataGridViewButtonColumn RuleRead;
        private System.Windows.Forms.DataGridViewButtonColumn RuleEdit;
        private System.Windows.Forms.DataGridViewButtonColumn RuleDelete;
    }
}
