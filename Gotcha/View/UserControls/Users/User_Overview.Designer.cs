
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
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User overview";
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(23, 89);
            this.AddUser.Margin = new System.Windows.Forms.Padding(4);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(103, 34);
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
            this.Active,
            this.btn_Edit,
            this.btn_Delete});
            this.dataGridView_Users.Location = new System.Drawing.Point(23, 130);
            this.dataGridView_Users.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.RowHeadersWidth = 51;
            this.dataGridView_Users.Size = new System.Drawing.Size(859, 394);
            this.dataGridView_Users.TabIndex = 2;
            this.dataGridView_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Users_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.Width = 125;
            // 
            // btn_Edit
            // 
            this.btn_Edit.HeaderText = "Edit";
            this.btn_Edit.MinimumWidth = 6;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.btn_Edit.Width = 125;
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "Delete";
            this.btn_Delete.MinimumWidth = 6;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.btn_Delete.Width = 125;
            // 
            // User_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_Users);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "User_Overview";
            this.Size = new System.Drawing.Size(909, 545);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_Delete;
    }
}
