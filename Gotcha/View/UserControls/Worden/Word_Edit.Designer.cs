
namespace Gotcha.View.UserControls.Worden
{
    partial class Word_Edit
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
            this.Btn_UpdateWord = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelworden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_UpdateWord
            // 
            this.Btn_UpdateWord.Location = new System.Drawing.Point(315, 184);
            this.Btn_UpdateWord.Name = "Btn_UpdateWord";
            this.Btn_UpdateWord.Size = new System.Drawing.Size(97, 33);
            this.Btn_UpdateWord.TabIndex = 21;
            this.Btn_UpdateWord.Text = "Update";
            this.Btn_UpdateWord.UseVisualStyleBackColor = true;
            this.Btn_UpdateWord.Click += new System.EventHandler(this.Btn_UpdateWord_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(189, 184);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(97, 33);
            this.Btn_Cancel.TabIndex = 20;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(179, 123);
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(233, 22);
            this.textBox_Content.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Content";
            // 
            // labelworden
            // 
            this.labelworden.AutoSize = true;
            this.labelworden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelworden.Location = new System.Drawing.Point(58, 42);
            this.labelworden.Name = "labelworden";
            this.labelworden.Size = new System.Drawing.Size(181, 32);
            this.labelworden.TabIndex = 17;
            this.labelworden.Text = "Update Word";
            // 
            // Word_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_UpdateWord);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.textBox_Content);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelworden);
            this.Name = "Word_Edit";
            this.Size = new System.Drawing.Size(470, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_UpdateWord;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelworden;
    }
}
