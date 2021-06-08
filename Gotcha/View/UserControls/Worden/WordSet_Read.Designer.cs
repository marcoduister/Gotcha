
namespace Gotcha.View.UserControls.Worden
{
    partial class WordSet_Read
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
            this.labelworden = new System.Windows.Forms.Label();
            this.dataGridView_worden = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_worden)).BeginInit();
            this.SuspendLayout();
            // 
            // labelworden
            // 
            this.labelworden.AutoSize = true;
            this.labelworden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelworden.Location = new System.Drawing.Point(34, 27);
            this.labelworden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelworden.Name = "labelworden";
            this.labelworden.Size = new System.Drawing.Size(155, 26);
            this.labelworden.TabIndex = 28;
            this.labelworden.Text = "Read WordSet";
            // 
            // dataGridView_worden
            // 
            this.dataGridView_worden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_worden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Word});
            this.dataGridView_worden.Location = new System.Drawing.Point(265, 13);
            this.dataGridView_worden.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_worden.Name = "dataGridView_worden";
            this.dataGridView_worden.RowHeadersWidth = 51;
            this.dataGridView_worden.RowTemplate.Height = 24;
            this.dataGridView_worden.Size = new System.Drawing.Size(179, 259);
            this.dataGridView_worden.TabIndex = 33;
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
            // WordSet_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_worden);
            this.Controls.Add(this.labelworden);
            this.Name = "WordSet_Read";
            this.Size = new System.Drawing.Size(682, 274);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_worden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelworden;
        private System.Windows.Forms.DataGridView dataGridView_worden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
    }
}
