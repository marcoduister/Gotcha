
namespace Gotcha.View.UserControls.Users
{
    partial class User_Edit
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserRol = new System.Windows.Forms.ComboBox();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.Email = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "First name";
            // 
            // UserRol
            // 
            this.UserRol.FormattingEnabled = true;
            this.UserRol.Location = new System.Drawing.Point(133, 226);
            this.UserRol.Name = "UserRol";
            this.UserRol.Size = new System.Drawing.Size(156, 21);
            this.UserRol.TabIndex = 16;
            // 
            // Birthdate
            // 
            this.Birthdate.Location = new System.Drawing.Point(177, 191);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(112, 20);
            this.Birthdate.TabIndex = 15;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(133, 153);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(156, 20);
            this.Email.TabIndex = 14;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(133, 115);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(156, 20);
            this.LastName.TabIndex = 13;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(133, 80);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(156, 20);
            this.FirstName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit user";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(454, 226);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(132, 39);
            this.Edit.TabIndex = 22;
            this.Edit.Text = "Edit user";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // User_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserRol);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Name = "User_Edit";
            this.Size = new System.Drawing.Size(682, 443);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UserRol;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit;
    }
}
