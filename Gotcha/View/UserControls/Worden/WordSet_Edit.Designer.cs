
namespace Gotcha.View.UserControls.Worden
{
    partial class WordSet_Edit
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelworden = new System.Windows.Forms.Label();
            this.dataGridView_worden = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_UpdateWordSet = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Word = new System.Windows.Forms.ComboBox();
            this.Btn_AddWord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_worden)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(179, 123);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(233, 22);
            this.textBox_Name.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // labelworden
            // 
            this.labelworden.AutoSize = true;
            this.labelworden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelworden.Location = new System.Drawing.Point(58, 42);
            this.labelworden.Name = "labelworden";
            this.labelworden.Size = new System.Drawing.Size(224, 32);
            this.labelworden.TabIndex = 27;
            this.labelworden.Text = "Update WordSet";
            // 
            // dataGridView_worden
            // 
            this.dataGridView_worden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_worden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Word,
            this.Delete});
            this.dataGridView_worden.Location = new System.Drawing.Point(453, 42);
            this.dataGridView_worden.Name = "dataGridView_worden";
            this.dataGridView_worden.RowHeadersWidth = 51;
            this.dataGridView_worden.RowTemplate.Height = 24;
            this.dataGridView_worden.Size = new System.Drawing.Size(395, 210);
            this.dataGridView_worden.TabIndex = 32;
            this.dataGridView_worden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_worden_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Word
            // 
            this.Word.HeaderText = "Word";
            this.Word.MinimumWidth = 6;
            this.Word.Name = "Word";
            this.Word.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // Btn_UpdateWordSet
            // 
            this.Btn_UpdateWordSet.Location = new System.Drawing.Point(751, 278);
            this.Btn_UpdateWordSet.Name = "Btn_UpdateWordSet";
            this.Btn_UpdateWordSet.Size = new System.Drawing.Size(97, 33);
            this.Btn_UpdateWordSet.TabIndex = 34;
            this.Btn_UpdateWordSet.Text = "Update";
            this.Btn_UpdateWordSet.UseVisualStyleBackColor = true;
            this.Btn_UpdateWordSet.Click += new System.EventHandler(this.Btn_UpdateWordSet_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(625, 278);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(97, 33);
            this.Btn_Cancel.TabIndex = 33;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // comboBox_Word
            // 
            this.comboBox_Word.FormattingEnabled = true;
            this.comboBox_Word.Location = new System.Drawing.Point(179, 171);
            this.comboBox_Word.Name = "comboBox_Word";
            this.comboBox_Word.Size = new System.Drawing.Size(233, 24);
            this.comboBox_Word.TabIndex = 35;
            // 
            // Btn_AddWord
            // 
            this.Btn_AddWord.Location = new System.Drawing.Point(315, 219);
            this.Btn_AddWord.Name = "Btn_AddWord";
            this.Btn_AddWord.Size = new System.Drawing.Size(97, 33);
            this.Btn_AddWord.TabIndex = 36;
            this.Btn_AddWord.Text = "Add";
            this.Btn_AddWord.UseVisualStyleBackColor = true;
            this.Btn_AddWord.Click += new System.EventHandler(this.Btn_AddWord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Worden";
            // 
            // WordSet_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_AddWord);
            this.Controls.Add(this.comboBox_Word);
            this.Controls.Add(this.Btn_UpdateWordSet);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.dataGridView_worden);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelworden);
            this.Name = "WordSet_Edit";
            this.Size = new System.Drawing.Size(910, 337);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_worden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelworden;
        private System.Windows.Forms.DataGridView dataGridView_worden;
        private System.Windows.Forms.Button Btn_UpdateWordSet;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox comboBox_Word;
        private System.Windows.Forms.Button Btn_AddWord;
        private System.Windows.Forms.Label label2;
    }
}
