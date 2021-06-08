
namespace Gotcha.View.UserControls.Rules
{
    partial class RuleSet_Read
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
            this.dataGridView_Rule = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Rule
            // 
            this.dataGridView_Rule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rule});
            this.dataGridView_Rule.Location = new System.Drawing.Point(276, 11);
            this.dataGridView_Rule.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Rule.Name = "dataGridView_Rule";
            this.dataGridView_Rule.RowHeadersWidth = 51;
            this.dataGridView_Rule.RowTemplate.Height = 24;
            this.dataGridView_Rule.Size = new System.Drawing.Size(178, 261);
            this.dataGridView_Rule.TabIndex = 33;
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
            // labelRule
            // 
            this.labelRule.AutoSize = true;
            this.labelRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule.Location = new System.Drawing.Point(27, 27);
            this.labelRule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRule.Name = "labelRule";
            this.labelRule.Size = new System.Drawing.Size(148, 26);
            this.labelRule.TabIndex = 34;
            this.labelRule.Text = "Read RuleSet";
            // 
            // RuleSet_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRule);
            this.Controls.Add(this.dataGridView_Rule);
            this.Name = "RuleSet_Read";
            this.Size = new System.Drawing.Size(682, 274);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Rule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rule;
        private System.Windows.Forms.Label labelRule;
    }
}
