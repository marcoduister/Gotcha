
namespace Gotcha
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Texbox_Password = new System.Windows.Forms.TextBox();
            this.Textbox_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texbox_Password
            // 
            this.Texbox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texbox_Password.Location = new System.Drawing.Point(300, 152);
            this.Texbox_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Texbox_Password.Name = "Texbox_Password";
            this.Texbox_Password.Size = new System.Drawing.Size(254, 27);
            this.Texbox_Password.TabIndex = 16;
            this.Texbox_Password.UseSystemPasswordChar = true;
            // 
            // Textbox_Email
            // 
            this.Textbox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Email.Location = new System.Drawing.Point(302, 93);
            this.Textbox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Textbox_Email.Name = "Textbox_Email";
            this.Textbox_Email.Size = new System.Drawing.Size(252, 27);
            this.Textbox_Email.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(94, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Wachtwoord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(94, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(434, 202);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 40);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 298);
            this.Controls.Add(this.Texbox_Password);
            this.Controls.Add(this.Textbox_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Texbox_Password;
        private System.Windows.Forms.TextBox Textbox_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
    }
}

