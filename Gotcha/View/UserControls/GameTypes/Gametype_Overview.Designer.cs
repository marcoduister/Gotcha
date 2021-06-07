
namespace Gotcha.View.UserControls.GameTypes
{
    partial class GameType_Overview
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
            this.dataGridView_GameType = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleSetMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleSetRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RuleSetEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RuleSetDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateGameType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GameType)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GameType
            // 
            this.dataGridView_GameType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GameType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.RuleSetMaker,
            this.RuleSetRead,
            this.RuleSetEdit,
            this.RuleSetDelete});
            this.dataGridView_GameType.Location = new System.Drawing.Point(57, 145);
            this.dataGridView_GameType.Name = "dataGridView_GameType";
            this.dataGridView_GameType.RowHeadersWidth = 51;
            this.dataGridView_GameType.RowTemplate.Height = 24;
            this.dataGridView_GameType.Size = new System.Drawing.Size(803, 361);
            this.dataGridView_GameType.TabIndex = 8;
            this.dataGridView_GameType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_GameType_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "GameType Overview";
            // 
            // button_CreateGameType
            // 
            this.button_CreateGameType.Location = new System.Drawing.Point(57, 104);
            this.button_CreateGameType.Name = "button_CreateGameType";
            this.button_CreateGameType.Size = new System.Drawing.Size(75, 23);
            this.button_CreateGameType.TabIndex = 9;
            this.button_CreateGameType.Text = "Create";
            this.button_CreateGameType.UseVisualStyleBackColor = true;
            this.button_CreateGameType.Click += new System.EventHandler(this.button_CreateGameType_Click);
            // 
            // GameType_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_GameType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CreateGameType);
            this.Size = new System.Drawing.Size(910, 545);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GameType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleSetMaker;
        private System.Windows.Forms.DataGridViewButtonColumn RuleSetRead;
        private System.Windows.Forms.DataGridViewButtonColumn RuleSetEdit;
        private System.Windows.Forms.DataGridViewButtonColumn RuleSetDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CreateGameType;
    }
}
