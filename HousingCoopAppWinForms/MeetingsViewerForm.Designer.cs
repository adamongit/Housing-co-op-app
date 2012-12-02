namespace HousingCoopAppWinForms
{
    partial class MeetingsViewerForm
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
            this.dgvMeetingsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeetingsDataGridView
            // 
            this.dgvMeetingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeetingsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.dgvMeetingsDataGridView.Name = "dgvMeetingsDataGridView";
            this.dgvMeetingsDataGridView.Size = new System.Drawing.Size(637, 253);
            this.dgvMeetingsDataGridView.TabIndex = 0;
            // 
            // MeetingsViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 277);
            this.Controls.Add(this.dgvMeetingsDataGridView);
            this.Name = "MeetingsViewerForm";
            this.Text = "Meetings Viewer";
            this.Load += new System.EventHandler(this.MeetingsViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetingsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeetingsDataGridView;
    }
}