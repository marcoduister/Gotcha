
namespace Gotcha.View.UserControls.Game
{
    partial class Game_Overview
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
            this.dataGridView_Games = new System.Windows.Forms.DataGridView();
            this.button_CreateGame = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnedit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Games)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Overview";
            // 
            // dataGridView_Games
            // 
            this.dataGridView_Games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Games.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.AmountPlayers,
            this.Start,
            this.Location,
            this.Maker,
            this.btnStart,
            this.btnRead,
            this.btnedit,
            this.btndelete});
            this.dataGridView_Games.Location = new System.Drawing.Point(50, 141);
            this.dataGridView_Games.Name = "dataGridView_Games";
            this.dataGridView_Games.RowHeadersWidth = 51;
            this.dataGridView_Games.RowTemplate.Height = 24;
            this.dataGridView_Games.Size = new System.Drawing.Size(803, 361);
            this.dataGridView_Games.TabIndex = 2;
            this.dataGridView_Games.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Games_CellContentClick);
            // 
            // button_CreateGame
            // 
            this.button_CreateGame.Location = new System.Drawing.Point(50, 100);
            this.button_CreateGame.Name = "button_CreateGame";
            this.button_CreateGame.Size = new System.Drawing.Size(75, 23);
            this.button_CreateGame.TabIndex = 3;
            this.button_CreateGame.Text = "Create";
            this.button_CreateGame.UseVisualStyleBackColor = true;
            this.button_CreateGame.Click += new System.EventHandler(this.button_CreateGame_Click);
            // 
            // btndelete
            // 
            this.btndelete.HeaderText = "Delete";
            this.btndelete.MinimumWidth = 6;
            this.btndelete.Name = "btndelete";
            this.btndelete.Width = 125;
            // 
            // btnedit
            // 
            this.btnedit.HeaderText = "Edit";
            this.btnedit.MinimumWidth = 6;
            this.btnedit.Name = "btnedit";
            this.btnedit.Width = 125;
            // 
            // btnRead
            // 
            this.btnRead.HeaderText = "Read";
            this.btnRead.MinimumWidth = 6;
            this.btnRead.Name = "btnRead";
            this.btnRead.Width = 125;
            // 
            // btnStart
            // 
            this.btnStart.HeaderText = "start";
            this.btnStart.MinimumWidth = 6;
            this.btnStart.Name = "btnStart";
            this.btnStart.Width = 125;
            // 
            // Maker
            // 
            this.Maker.HeaderText = "Maker";
            this.Maker.MinimumWidth = 6;
            this.Maker.Name = "Maker";
            this.Maker.Width = 125;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 125;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.MinimumWidth = 6;
            this.Start.Name = "Start";
            this.Start.Width = 125;
            // 
            // AmountPlayers
            // 
            this.AmountPlayers.HeaderText = "AmountPlayers";
            this.AmountPlayers.MinimumWidth = 6;
            this.AmountPlayers.Name = "AmountPlayers";
            this.AmountPlayers.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Game_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_CreateGame);
            this.Controls.Add(this.dataGridView_Games);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(910, 545);
            this.Load += new System.EventHandler(this.Game_Overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Games)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Games;
        private System.Windows.Forms.Button button_CreateGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maker;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnedit;
        private System.Windows.Forms.DataGridViewTextBoxColumn btndelete;
    }
}
