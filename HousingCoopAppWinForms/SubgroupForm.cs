using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObjects;
using DataAccessLayer;
using System.Configuration;

namespace HousingCoopAppWinForms
{
    public partial class SubgroupForm : Form
    {
        public SubgroupForm(WindowOpenState windowState = WindowOpenState.View, int subGroupIdToView = 0)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SubGroupDataContext sdc = new SubGroupDataContext(
                ConfigurationManager.ConnectionStrings["hamwicConnectionString"].ConnectionString);

            Subgroup newSubgroup = new Subgroup
            {
                Name = txtSubgroupName.Text
            };

            sdc.Subgroups.InsertOnSubmit(newSubgroup);

            try
            {
                sdc.SubmitChanges();

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

        private void SubgroupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
