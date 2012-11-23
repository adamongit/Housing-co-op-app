namespace HousingCoopAppWinForms
{
    partial class SubgroupForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbSubgroup = new System.Windows.Forms.Label();
            this.txtSubgroupName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(203, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(313, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbSubgroup
            // 
            this.lbSubgroup.AutoSize = true;
            this.lbSubgroup.Location = new System.Drawing.Point(39, 42);
            this.lbSubgroup.Name = "lbSubgroup";
            this.lbSubgroup.Size = new System.Drawing.Size(87, 13);
            this.lbSubgroup.TabIndex = 10;
            this.lbSubgroup.Text = "Subgroup Name:";
            // 
            // txtSubgroupName
            // 
            this.txtSubgroupName.Location = new System.Drawing.Point(142, 39);
            this.txtSubgroupName.MaxLength = 50;
            this.txtSubgroupName.Name = "txtSubgroupName";
            this.txtSubgroupName.Size = new System.Drawing.Size(268, 20);
            this.txtSubgroupName.TabIndex = 11;
            // 
            // SubgroupForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 118);
            this.Controls.Add(this.txtSubgroupName);
            this.Controls.Add(this.lbSubgroup);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "SubgroupForm";
            this.Text = "Subgroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbSubgroup;
        private System.Windows.Forms.TextBox txtSubgroupName;
    }
}