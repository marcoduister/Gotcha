
namespace Gotcha.View.UserControls.Users
{
    partial class User_Overview
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddUser = new System.Windows.Forms.Button();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "User overview";
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(17, 72);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(77, 28);
            this.AddUser.TabIndex = 1;
            this.AddUser.Text = "Add user";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Birthdate,
            this.btn_Edit,
            this.btn_Delete});
            this.dataGridView_Users.Location = new System.Drawing.Point(17, 106);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.Size = new System.Drawing.Size(644, 320);
            this.dataGridView_Users.TabIndex = 2;
            this.dataGridView_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Users_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            // 
            // btn_Edit
            // 
            this.btn_Edit.HeaderText = "Edit";
            this.btn_Edit.Name = "btn_Edit";
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "Delete";
            this.btn_Delete.Name = "btn_Delete";
            // 
            // User_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_Users);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.label1);
            this.Name = "User_Overview";
            this.Size = new System.Drawing.Size(682, 443);
            this.Load += new System.EventHandler(this.User_Overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
    }
}
