namespace HousingCoopAppWinForms
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
            this.msMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMeetingMenutClick = new System.Windows.Forms.ToolStripMenuItem();
            this.contractorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subgroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenuStrip
            // 
            this.msMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.meetingsToolStripMenuItem,
            this.contractorsToolStripMenuItem,
            this.subgroupsToolStripMenuItem});
            this.msMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.msMainMenuStrip.Name = "msMainMenuStrip";
            this.msMainMenuStrip.Size = new System.Drawing.Size(820, 24);
            this.msMainMenuStrip.TabIndex = 0;
            this.msMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // meetingsToolStripMenuItem
            // 
            this.meetingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMeetingMenutClick});
            this.meetingsToolStripMenuItem.Name = "meetingsToolStripMenuItem";
            this.meetingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.meetingsToolStripMenuItem.Text = "Meetings";
            // 
            // newMeetingMenutClick
            // 
            this.newMeetingMenutClick.Name = "newMeetingMenutClick";
            this.newMeetingMenutClick.Size = new System.Drawing.Size(98, 22);
            this.newMeetingMenutClick.Text = "New";
            this.newMeetingMenutClick.Click += new System.EventHandler(this.newMeetingMenuClick_Click);
            // 
            // contractorsToolStripMenuItem
            // 
            this.contractorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
            this.contractorsToolStripMenuItem.Name = "contractorsToolStripMenuItem";
            this.contractorsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.contractorsToolStripMenuItem.Text = "Contractors";
            // 
            // subgroupsToolStripMenuItem
            // 
            this.subgroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.subgroupsToolStripMenuItem.Name = "subgroupsToolStripMenuItem";
            this.subgroupsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.subgroupsToolStripMenuItem.Text = "Subgroups";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 461);
            this.Controls.Add(this.msMainMenuStrip);
            this.MainMenuStrip = this.msMainMenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMainMenuStrip.ResumeLayout(false);
            this.msMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMeetingMenutClick;
        private System.Windows.Forms.ToolStripMenuItem contractorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subgroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
    }
}

