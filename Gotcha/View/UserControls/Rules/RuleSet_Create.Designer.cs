
namespace Gotcha.View.UserControls.Rules
{
    partial class RuleSet_Create
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
            this.Btn_CreateRuleSet = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.labelRule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_CreateRuleSet
            // 
            this.Btn_CreateRuleSet.Location = new System.Drawing.Point(315, 184);
            this.Btn_CreateRuleSet.Name = "Btn_CreateRuleSet";
            this.Btn_CreateRuleSet.Size = new System.Drawing.Size(97, 33);
            this.Btn_CreateRuleSet.TabIndex = 26;
            this.Btn_CreateRuleSet.Text = "Create";
            this.Btn_CreateRuleSet.UseVisualStyleBackColor = true;
            this.Btn_CreateRuleSet.Click += new System.EventHandler(this.Btn_CreateRuleSet_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(189, 184);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(97, 33);
            this.Btn_Cancel.TabIndex = 25;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // labelRule
            // 
            this.labelRule.AutoSize = true;
            this.labelRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule.Location = new System.Drawing.Point(58, 42);
            this.labelRule.Name = "labelRule";
            this.labelRule.Size = new System.Drawing.Size(209, 32);
            this.labelRule.TabIndex = 22;
            this.labelRule.Text = "Create RuleSet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(179, 123);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(233, 22);
            this.textBox_Name.TabIndex = 24;
            // 
            // RuleSet_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_CreateRuleSet);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRule);
            this.Name = "RuleSet_Create";
            this.Size = new System.Drawing.Size(470, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CreateRuleSet;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label labelRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
    }
}
