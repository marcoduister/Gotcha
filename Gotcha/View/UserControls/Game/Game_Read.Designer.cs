
namespace Gotcha.View.UserControls.Game
{
    partial class Game_Read
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Location = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_gameUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Kill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.textBox_Winner = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Second = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Most = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxActivePlayer = new System.Windows.Forms.TextBox();
            this.textBox_Random = new System.Windows.Forms.TextBox();
            this.TextBox_Best = new System.Windows.Forms.MaskedTextBox();
            this.textBox_gameType = new System.Windows.Forms.TextBox();
            this.textBox_ruleset = new System.Windows.Forms.TextBox();
            this.textBox_wordset = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Startdatum";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(148, 41);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(233, 22);
            this.textBox_Name.TabIndex = 3;
            // 
            // textBox_Location
            // 
            this.textBox_Location.Location = new System.Drawing.Point(148, 81);
            this.textBox_Location.Name = "textBox_Location";
            this.textBox_Location.ReadOnly = true;
            this.textBox_Location.Size = new System.Drawing.Size(233, 22);
            this.textBox_Location.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enddatum";
            // 
            // dataGridView_gameUsers
            // 
            this.dataGridView_gameUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_gameUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.User,
            this.word,
            this.btn_Kill});
            this.dataGridView_gameUsers.Location = new System.Drawing.Point(473, 43);
            this.dataGridView_gameUsers.Name = "dataGridView_gameUsers";
            this.dataGridView_gameUsers.RowHeadersWidth = 51;
            this.dataGridView_gameUsers.RowTemplate.Height = 24;
            this.dataGridView_gameUsers.Size = new System.Drawing.Size(396, 365);
            this.dataGridView_gameUsers.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.Width = 125;
            // 
            // word
            // 
            this.word.HeaderText = "word";
            this.word.MinimumWidth = 6;
            this.word.Name = "word";
            this.word.Width = 125;
            // 
            // btn_Kill
            // 
            this.btn_Kill.HeaderText = "Killed";
            this.btn_Kill.MinimumWidth = 6;
            this.btn_Kill.Name = "btn_Kill";
            this.btn_Kill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Kill.Width = 125;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(772, 443);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(97, 33);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // textBox_Winner
            // 
            this.textBox_Winner.Location = new System.Drawing.Point(148, 249);
            this.textBox_Winner.Name = "textBox_Winner";
            this.textBox_Winner.ReadOnly = true;
            this.textBox_Winner.Size = new System.Drawing.Size(100, 22);
            this.textBox_Winner.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Winner";
            // 
            // textBox_Second
            // 
            this.textBox_Second.Location = new System.Drawing.Point(281, 249);
            this.textBox_Second.Name = "textBox_Second";
            this.textBox_Second.ReadOnly = true;
            this.textBox_Second.Size = new System.Drawing.Size(100, 22);
            this.textBox_Second.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Second";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Most";
            // 
            // textBox_Most
            // 
            this.textBox_Most.Location = new System.Drawing.Point(281, 301);
            this.textBox_Most.Name = "textBox_Most";
            this.textBox_Most.ReadOnly = true;
            this.textBox_Most.Size = new System.Drawing.Size(100, 22);
            this.textBox_Most.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(144, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Best";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(144, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Random";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "RuleSet";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "WordSet";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "GameType";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Enabled = false;
            this.dateTimePicker_End.Location = new System.Drawing.Point(148, 160);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker_End.TabIndex = 33;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Enabled = false;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(148, 120);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker_Start.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Active players";
            // 
            // textBoxActivePlayer
            // 
            this.textBoxActivePlayer.Location = new System.Drawing.Point(148, 195);
            this.textBoxActivePlayer.Name = "textBoxActivePlayer";
            this.textBoxActivePlayer.ReadOnly = true;
            this.textBoxActivePlayer.Size = new System.Drawing.Size(233, 22);
            this.textBoxActivePlayer.TabIndex = 36;
            // 
            // textBox_Random
            // 
            this.textBox_Random.Location = new System.Drawing.Point(148, 348);
            this.textBox_Random.Name = "textBox_Random";
            this.textBox_Random.ReadOnly = true;
            this.textBox_Random.Size = new System.Drawing.Size(100, 22);
            this.textBox_Random.TabIndex = 39;
            // 
            // TextBox_Best
            // 
            this.TextBox_Best.Location = new System.Drawing.Point(148, 301);
            this.TextBox_Best.Name = "TextBox_Best";
            this.TextBox_Best.ReadOnly = true;
            this.TextBox_Best.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Best.TabIndex = 40;
            // 
            // textBox_gameType
            // 
            this.textBox_gameType.Location = new System.Drawing.Point(148, 467);
            this.textBox_gameType.Name = "textBox_gameType";
            this.textBox_gameType.ReadOnly = true;
            this.textBox_gameType.Size = new System.Drawing.Size(233, 22);
            this.textBox_gameType.TabIndex = 41;
            // 
            // textBox_ruleset
            // 
            this.textBox_ruleset.Location = new System.Drawing.Point(148, 384);
            this.textBox_ruleset.Name = "textBox_ruleset";
            this.textBox_ruleset.ReadOnly = true;
            this.textBox_ruleset.Size = new System.Drawing.Size(233, 22);
            this.textBox_ruleset.TabIndex = 42;
            // 
            // textBox_wordset
            // 
            this.textBox_wordset.Location = new System.Drawing.Point(148, 423);
            this.textBox_wordset.Name = "textBox_wordset";
            this.textBox_wordset.ReadOnly = true;
            this.textBox_wordset.Size = new System.Drawing.Size(233, 22);
            this.textBox_wordset.TabIndex = 43;
            // 
            // Game_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_wordset);
            this.Controls.Add(this.textBox_ruleset);
            this.Controls.Add(this.textBox_gameType);
            this.Controls.Add(this.TextBox_Best);
            this.Controls.Add(this.textBox_Random);
            this.Controls.Add(this.textBoxActivePlayer);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker_Start);
            this.Controls.Add(this.dateTimePicker_End);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Most);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Second);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Winner);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.dataGridView_gameUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Location);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Game_Read";
            this.Size = new System.Drawing.Size(910, 545);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gameUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_gameUsers;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox textBox_Winner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Second;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Most;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxActivePlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_Kill;
        private System.Windows.Forms.TextBox textBox_Random;
        private System.Windows.Forms.MaskedTextBox TextBox_Best;
        private System.Windows.Forms.TextBox textBox_gameType;
        private System.Windows.Forms.TextBox textBox_ruleset;
        private System.Windows.Forms.TextBox textBox_wordset;
    }
}
