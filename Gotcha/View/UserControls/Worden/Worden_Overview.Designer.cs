
namespace Gotcha.View.UserControls.Worden
{
    partial class Worden_Overview
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabWordSet = new System.Windows.Forms.TabPage();
            this.dataGridView_Wordset = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordSetMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordSetRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.WordSetEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.WordSetDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateWordSet = new System.Windows.Forms.Button();
            this.TabWorden = new System.Windows.Forms.TabPage();
            this.dataGridView_Worden = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordMaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.WordEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.WordDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelworden = new System.Windows.Forms.Label();
            this.button_CreateWorden = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.TabWordSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Wordset)).BeginInit();
            this.TabWorden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Worden)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabWordSet);
            this.TabControl.Controls.Add(this.TabWorden);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(907, 545);
            this.TabControl.TabIndex = 0;
            // 
            // TabWordSet
            // 
            this.TabWordSet.Controls.Add(this.dataGridView_Wordset);
            this.TabWordSet.Controls.Add(this.label1);
            this.TabWordSet.Controls.Add(this.button_CreateWordSet);
            this.TabWordSet.Location = new System.Drawing.Point(4, 25);
            this.TabWordSet.Name = "TabWordSet";
            this.TabWordSet.Padding = new System.Windows.Forms.Padding(3);
            this.TabWordSet.Size = new System.Drawing.Size(899, 516);
            this.TabWordSet.TabIndex = 0;
            this.TabWordSet.Text = "WordSet";
            this.TabWordSet.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Wordset
            // 
            this.dataGridView_Wordset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Wordset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.WordSetMaker,
            this.WordSetRead,
            this.WordSetEdit,
            this.WordSetDelete});
            this.dataGridView_Wordset.Location = new System.Drawing.Point(51, 131);
            this.dataGridView_Wordset.Name = "dataGridView_Wordset";
            this.dataGridView_Wordset.RowHeadersWidth = 51;
            this.dataGridView_Wordset.RowTemplate.Height = 24;
            this.dataGridView_Wordset.Size = new System.Drawing.Size(803, 361);
            this.dataGridView_Wordset.TabIndex = 5;
            this.dataGridView_Wordset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Wordset_CellContentClick);
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
            // WordSetMaker
            // 
            this.WordSetMaker.HeaderText = "Maker";
            this.WordSetMaker.MinimumWidth = 6;
            this.WordSetMaker.Name = "WordSetMaker";
            this.WordSetMaker.Width = 125;
            // 
            // WordSetRead
            // 
            this.WordSetRead.HeaderText = "Read";
            this.WordSetRead.MinimumWidth = 6;
            this.WordSetRead.Name = "WordSetRead";
            this.WordSetRead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WordSetRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WordSetRead.Text = "Read";
            this.WordSetRead.UseColumnTextForButtonValue = true;
            this.WordSetRead.Width = 125;
            // 
            // WordSetEdit
            // 
            this.WordSetEdit.HeaderText = "Edit";
            this.WordSetEdit.MinimumWidth = 6;
            this.WordSetEdit.Name = "WordSetEdit";
            this.WordSetEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WordSetEdit.Text = "Edit";
            this.WordSetEdit.UseColumnTextForButtonValue = true;
            this.WordSetEdit.Width = 125;
            // 
            // WordSetDelete
            // 
            this.WordSetDelete.HeaderText = "Delete";
            this.WordSetDelete.MinimumWidth = 6;
            this.WordSetDelete.Name = "WordSetDelete";
            this.WordSetDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WordSetDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WordSetDelete.Text = "Delete";
            this.WordSetDelete.UseColumnTextForButtonValue = true;
            this.WordSetDelete.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "WordSet Overview";
            // 
            // button_CreateWordSet
            // 
            this.button_CreateWordSet.Location = new System.Drawing.Point(51, 90);
            this.button_CreateWordSet.Name = "button_CreateWordSet";
            this.button_CreateWordSet.Size = new System.Drawing.Size(75, 23);
            this.button_CreateWordSet.TabIndex = 6;
            this.button_CreateWordSet.Text = "Create";
            this.button_CreateWordSet.UseVisualStyleBackColor = true;
            this.button_CreateWordSet.Click += new System.EventHandler(this.button_CreateWordSet_Click);
            // 
            // TabWorden
            // 
            this.TabWorden.Controls.Add(this.dataGridView_Worden);
            this.TabWorden.Controls.Add(this.labelworden);
            this.TabWorden.Controls.Add(this.button_CreateWorden);
            this.TabWorden.Location = new System.Drawing.Point(4, 25);
            this.TabWorden.Name = "TabWorden";
            this.TabWorden.Padding = new System.Windows.Forms.Padding(3);
            this.TabWorden.Size = new System.Drawing.Size(899, 516);
            this.TabWorden.TabIndex = 1;
            this.TabWorden.Text = "Word";
            this.TabWorden.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Worden
            // 
            this.dataGridView_Worden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Worden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Content,
            this.WordMaker,
            this.WordRead,
            this.WordEdit,
            this.WordDelete});
            this.dataGridView_Worden.Location = new System.Drawing.Point(51, 131);
            this.dataGridView_Worden.Name = "dataGridView_Worden";
            this.dataGridView_Worden.RowHeadersWidth = 51;
            this.dataGridView_Worden.RowTemplate.Height = 24;
            this.dataGridView_Worden.Size = new System.Drawing.Size(803, 361);
            this.dataGridView_Worden.TabIndex = 5;
            this.dataGridView_Worden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Worden_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.Width = 125;
            // 
            // WordMaker
            // 
            this.WordMaker.HeaderText = "Maker";
            this.WordMaker.MinimumWidth = 6;
            this.WordMaker.Name = "WordMaker";
            this.WordMaker.Width = 125;
            // 
            // WordRead
            // 
            this.WordRead.HeaderText = "Read";
            this.WordRead.MinimumWidth = 6;
            this.WordRead.Name = "WordRead";
            this.WordRead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WordRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WordRead.Text = "Read";
            this.WordRead.UseColumnTextForButtonValue = true;
            this.WordRead.Width = 125;
            // 
            // WordEdit
            // 
            this.WordEdit.HeaderText = "Edit";
            this.WordEdit.MinimumWidth = 6;
            this.WordEdit.Name = "WordEdit";
            this.WordEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WordEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WordEdit.Text = "Edit";
            this.WordEdit.UseColumnTextForButtonValue = true;
            this.WordEdit.Width = 125;
            // 
            // WordDelete
            // 
            this.WordDelete.HeaderText = "Delete";
            this.WordDelete.MinimumWidth = 6;
            this.WordDelete.Name = "WordDelete";
            this.WordDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WordDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WordDelete.Text = "Delete";
            this.WordDelete.UseColumnTextForButtonValue = true;
            this.WordDelete.Width = 125;
            // 
            // labelworden
            // 
            this.labelworden.AutoSize = true;
            this.labelworden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelworden.Location = new System.Drawing.Point(45, 24);
            this.labelworden.Name = "labelworden";
            this.labelworden.Size = new System.Drawing.Size(239, 32);
            this.labelworden.TabIndex = 4;
            this.labelworden.Text = "Worden Overview";
            // 
            // button_CreateWorden
            // 
            this.button_CreateWorden.Location = new System.Drawing.Point(51, 90);
            this.button_CreateWorden.Name = "button_CreateWorden";
            this.button_CreateWorden.Size = new System.Drawing.Size(75, 23);
            this.button_CreateWorden.TabIndex = 6;
            this.button_CreateWorden.Text = "Create";
            this.button_CreateWorden.UseVisualStyleBackColor = true;
            this.button_CreateWorden.Click += new System.EventHandler(this.button_CreateWorden_Click);
            // 
            // Worden_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Size = new System.Drawing.Size(910, 545);
            this.TabControl.ResumeLayout(false);
            this.TabWordSet.ResumeLayout(false);
            this.TabWordSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Wordset)).EndInit();
            this.TabWorden.ResumeLayout(false);
            this.TabWorden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Worden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabWordSet;
        private System.Windows.Forms.DataGridView dataGridView_Wordset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CreateWordSet;
        private System.Windows.Forms.TabPage TabWorden;
        private System.Windows.Forms.DataGridView dataGridView_Worden;
        private System.Windows.Forms.Label labelworden;
        private System.Windows.Forms.Button button_CreateWorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordSetMaker;
        private System.Windows.Forms.DataGridViewButtonColumn WordSetRead;
        private System.Windows.Forms.DataGridViewButtonColumn WordSetEdit;
        private System.Windows.Forms.DataGridViewButtonColumn WordSetDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordMaker;
        private System.Windows.Forms.DataGridViewButtonColumn WordRead;
        private System.Windows.Forms.DataGridViewButtonColumn WordEdit;
        private System.Windows.Forms.DataGridViewButtonColumn WordDelete;
    }
}
