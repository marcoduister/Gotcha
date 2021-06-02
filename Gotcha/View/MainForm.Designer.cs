
namespace Gotcha.View
{
    partial class MainForm
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(179, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(993, 554);
            this.panel_Main.TabIndex = 2;
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.wordenToolStripMenuItem,
            this.gameTypeToolStripMenuItem});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(179, 554);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "Menu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(166, 45);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(166, 45);
            this.rulesToolStripMenuItem.Text = "Rules";
            // 
            // wordenToolStripMenuItem
            // 
            this.wordenToolStripMenuItem.Name = "wordenToolStripMenuItem";
            this.wordenToolStripMenuItem.Size = new System.Drawing.Size(166, 45);
            this.wordenToolStripMenuItem.Text = "Worden";
            // 
            // gameTypeToolStripMenuItem
            // 
            this.gameTypeToolStripMenuItem.Name = "gameTypeToolStripMenuItem";
            this.gameTypeToolStripMenuItem.Size = new System.Drawing.Size(166, 45);
            this.gameTypeToolStripMenuItem.Text = "GameType";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 554);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameTypeToolStripMenuItem;
    }
}