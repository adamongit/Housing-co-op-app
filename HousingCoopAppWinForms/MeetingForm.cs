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
    public partial class MeetingForm : Form
    {
        public MeetingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingForm" /> class.
        /// </summary>
        /// <param name="meeting">The meeting to display</param>
        public MeetingForm(Meeting meeting)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime datetimeFrom = GetDateTimeFrom();
            DateTime datetimeTo = GetDateTimeTo();

            if (datetimeFrom >= datetimeTo)
            {
                MessageBox.Show("Meeting end time must be later than the meeting start time.",
                    "Problem with input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MeetingDataContext mdc = new MeetingDataContext(
                    ConfigurationManager.ConnectionStrings["hamwicConnectionString"].ConnectionString);

                Meeting newMeeting = new Meeting
                {
                    DateTimeFrom = this.dtpTimeFrom.Value,
                    DateTimeTo = this.dtpTimeTo.Value,
                    Location_ = this.txtLocation.Text,
                    SubGroupId = (cbSubgroup.SelectedItem as Subgroup).Id
                };

                mdc.Meetings.InsertOnSubmit(newMeeting);
                
                try
                {
                    mdc.SubmitChanges();

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

        /// <summary>
        /// Gets the date time to.
        /// </summary>
        /// <returns></returns>
        private DateTime GetDateTimeTo()
        {
            DateTime dtTo =
               DateTime.Parse(
                   dtpDateTo.Value.ToShortDateString());

            TimeSpan tsTo = TimeSpan.Parse
            (dtpTimeTo.Value.ToLongTimeString());

            dtTo = dtTo.Date + tsTo;

            return dtTo;
        }

        /// <summary>
        /// Gets the date time from.
        /// </summary>
        /// <returns></returns>
        private DateTime GetDateTimeFrom()
        {
            DateTime dtFrom = 
                DateTime.Parse(
                    dtpDateFrom.Value.ToShortDateString());

            TimeSpan tsFrom = TimeSpan.Parse
            (dtpTimeFrom.Value.ToLongTimeString());

            dtFrom = dtFrom.Date + tsFrom;

            return dtFrom;

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
        /// Handles the Load event of the MeetingForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void MeetingForm_Load(object sender, EventArgs e)
        {
            SubGroupDataContext sgdc = new SubGroupDataContext(
                ConfigurationManager.ConnectionStrings["hamwicConnectionString"].ConnectionString);

            var subgroups = from s in sgdc.Customers select s;

            cbSubgroup.DataSource = subgroups;
            cbSubgroup.DisplayMember = "Name";
            cbSubgroup.ValueMember = "Id"; 
        }

        /// <summary>
        /// Handles the ValueChanged event of the dtpFrom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the ValueChanged event of the dtpTo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
