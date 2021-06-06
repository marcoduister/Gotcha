
namespace Gotcha.View.UserControls.Rules
{
    partial class RuleSet_Edit
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRule = new System.Windows.Forms.Label();
            this.dataGridView_Rule = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_UpdateRuleSet = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Rule = new System.Windows.Forms.ComboBox();
            this.Btn_AddRule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rule)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(179, 123);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(233, 22);
            this.textBox_Name.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // labelRule
            // 
            this.labelRule.AutoSize = true;
            this.labelRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule.Location = new System.Drawing.Point(58, 42);
            this.labelRule.Name = "labelRule";
            this.labelRule.Size = new System.Drawing.Size(216, 32);
            this.labelRule.TabIndex = 27;
            this.labelRule.Text = "Update RuleSet";
            // 
            // dataGridView_Rule
            // 
            this.dataGridView_Rule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rule,
            this.Delete});
            this.dataGridView_Rule.Location = new System.Drawing.Point(453, 42);
            this.dataGridView_Rule.Name = "dataGridView_Rule";
            this.dataGridView_Rule.RowHeadersWidth = 51;
            this.dataGridView_Rule.RowTemplate.Height = 24;
            this.dataGridView_Rule.Size = new System.Drawing.Size(395, 210);
            this.dataGridView_Rule.TabIndex = 32;
            this.dataGridView_Rule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Rule_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Rule
            // 
            this.Rule.HeaderText = "Rule";
            this.Rule.MinimumWidth = 6;
            this.Rule.Name = "Rule";
            this.Rule.ReadOnly = true;
            this.Rule.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // Btn_UpdateRuleSet
            // 
            this.Btn_UpdateRuleSet.Location = new System.Drawing.Point(751, 278);
            this.Btn_UpdateRuleSet.Name = "Btn_UpdateRuleSet";
            this.Btn_UpdateRuleSet.Size = new System.Drawing.Size(97, 33);
            this.Btn_UpdateRuleSet.TabIndex = 34;
            this.Btn_UpdateRuleSet.Text = "Update";
            this.Btn_UpdateRuleSet.UseVisualStyleBackColor = true;
            this.Btn_UpdateRuleSet.Click += new System.EventHandler(this.Btn_UpdateRuleSet_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(625, 278);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(97, 33);
            this.Btn_Cancel.TabIndex = 33;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // comboBox_Rule
            // 
            this.comboBox_Rule.FormattingEnabled = true;
            this.comboBox_Rule.Location = new System.Drawing.Point(179, 171);
            this.comboBox_Rule.Name = "comboBox_Rule";
            this.comboBox_Rule.Size = new System.Drawing.Size(233, 24);
            this.comboBox_Rule.TabIndex = 35;
            // 
            // Btn_AddRule
            // 
            this.Btn_AddRule.Location = new System.Drawing.Point(315, 219);
            this.Btn_AddRule.Name = "Btn_AddRule";
            this.Btn_AddRule.Size = new System.Drawing.Size(97, 33);
            this.Btn_AddRule.TabIndex = 36;
            this.Btn_AddRule.Text = "Add";
            this.Btn_AddRule.UseVisualStyleBackColor = true;
            this.Btn_AddRule.Click += new System.EventHandler(this.Btn_AddRule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Rule";
            // 
            // RuleSet_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_AddRule);
            this.Controls.Add(this.comboBox_Rule);
            this.Controls.Add(this.Btn_UpdateRuleSet);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.dataGridView_Rule);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRule);
            this.Name = "RuleSet_Edit";
            this.Size = new System.Drawing.Size(910, 337);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRule;
        private System.Windows.Forms.DataGridView dataGridView_Rule;
        private System.Windows.Forms.Button Btn_UpdateRuleSet;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rule;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox comboBox_Rule;
        private System.Windows.Forms.Button Btn_AddRule;
        private System.Windows.Forms.Label label2;
    }
}
