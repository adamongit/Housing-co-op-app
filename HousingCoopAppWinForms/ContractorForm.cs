using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using System.Configuration;
using BusinessObjects;

namespace HousingCoopAppWinForms
{
    public partial class ContractorForm : Form
    {
        /// <summary>
        /// The intended use for this instance of the form.
        /// </summary>
        private WindowOpenState WinState { get; set; }
        /// <summary>
        /// Gets or sets the contractor id to view.
        /// </summary>
        /// <value>
        /// The contractor id to view.
        /// </value>
        public int ContractorIdToView { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractorForm" /> class.
        /// </summary>
        /// <param name="windowState">State of the window.</param>
        public ContractorForm(WindowOpenState windowState = WindowOpenState.View, int contractorIdToView = 0)
        {
            this.WinState = windowState;
            this.ContractorIdToView = contractorIdToView;
            InitializeComponent();

        }

        private void ContractorForm_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; // TODO
            cbAddresses.Items.Clear();
        }

        /// <summary>
        /// Handles the Click event of the btnAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ContractorDataContext cdc = new ContractorDataContext(
                ConfigurationManager.ConnectionStrings["hamwicConnectionString"].ConnectionString);
            
            Contractor c = new Contractor{
                Name = txtContractorName.Text
            };

            cdc.Contractors.InsertOnSubmit(c);

            try
            {
                cdc.SubmitChanges();

                MessageBox.Show("Changes saved successfully",
                    "The database has been updated.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to save Changes",
                    "Problem committing to database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
                
        }

    }
}
