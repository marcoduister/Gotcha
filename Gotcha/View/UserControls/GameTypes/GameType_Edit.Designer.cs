
namespace Gotcha.View.UserControls.GameTypes
{
    partial class GameType_Edit
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
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_UpdateGameType = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(179, 136);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(233, 22);
            this.textBox_Description.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Description";
            // 
            // Btn_UpdateGameType
            // 
            this.Btn_UpdateGameType.Location = new System.Drawing.Point(315, 184);
            this.Btn_UpdateGameType.Name = "Btn_UpdateGameType";
            this.Btn_UpdateGameType.Size = new System.Drawing.Size(97, 33);
            this.Btn_UpdateGameType.TabIndex = 23;
            this.Btn_UpdateGameType.Text = "Update";
            this.Btn_UpdateGameType.UseVisualStyleBackColor = true;
            this.Btn_UpdateGameType.Click += new System.EventHandler(this.Btn_UpdateGameType_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(189, 184);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(97, 33);
            this.Btn_Cancel.TabIndex = 22;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(179, 93);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(233, 22);
            this.textBox_Name.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // labelRule
            // 
            this.labelRule.AutoSize = true;
            this.labelRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRule.Location = new System.Drawing.Point(58, 42);
            this.labelRule.Name = "labelRule";
            this.labelRule.Size = new System.Drawing.Size(212, 32);
            this.labelRule.TabIndex = 19;
            this.labelRule.Text = "Edit GameType";
            // 
            // GameType_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_UpdateGameType);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRule);
            this.Name = "GameType_Edit";
            this.Size = new System.Drawing.Size(470, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_UpdateGameType;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRule;
    }
}
