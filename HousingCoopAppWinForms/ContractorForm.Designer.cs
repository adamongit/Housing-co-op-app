namespace HousingCoopAppWinForms
{
    partial class ContractorForm
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
            this.cbAddresses = new System.Windows.Forms.ComboBox();
            this.LblAddresses = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblContractorName = new System.Windows.Forms.Label();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAddresses
            // 
            this.cbAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddresses.FormattingEnabled = true;
            this.cbAddresses.Location = new System.Drawing.Point(133, 71);
            this.cbAddresses.Name = "cbAddresses";
            this.cbAddresses.Size = new System.Drawing.Size(270, 21);
            this.cbAddresses.TabIndex = 11;
            // 
            // LblAddresses
            // 
            this.LblAddresses.AutoSize = true;
            this.LblAddresses.Location = new System.Drawing.Point(24, 74);
            this.LblAddresses.Name = "LblAddresses";
            this.LblAddresses.Size = new System.Drawing.Size(59, 13);
            this.LblAddresses.TabIndex = 10;
            this.LblAddresses.Text = "Addresses:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(328, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblContractorName
            // 
            this.lblContractorName.AutoSize = true;
            this.lblContractorName.Location = new System.Drawing.Point(24, 32);
            this.lblContractorName.Name = "lblContractorName";
            this.lblContractorName.Size = new System.Drawing.Size(90, 13);
            this.lblContractorName.TabIndex = 7;
            this.lblContractorName.Text = "Contractor Name:";
            // 
            // txtContractorName
            // 
            this.txtContractorName.Location = new System.Drawing.Point(133, 32);
            this.txtContractorName.MaxLength = 50;
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(270, 20);
            this.txtContractorName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(409, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ContractorForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(452, 227);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbAddresses);
            this.Controls.Add(this.LblAddresses);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblContractorName);
            this.Controls.Add(this.txtContractorName);
            this.Name = "ContractorForm";
            this.Text = "Contractor Form";
            this.Load += new System.EventHandler(this.ContractorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAddresses;
        private System.Windows.Forms.Label LblAddresses;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblContractorName;
        private System.Windows.Forms.TextBox txtContractorName;
        private System.Windows.Forms.Button btnAdd;
    }
}