using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObjects;

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
            Meeting newMeeting = new Meeting();
            newMeeting.DateTimeFrom = this.dtpFrom.Value;
            newMeeting.DateTimeTo = this.dtpTo.Value;
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
            cbSubgroup.DataSource = new BindingSource(Subgroup.GetAll(),null);
            cbSubgroup.DisplayMember = "Value";
            cbSubgroup.ValueMember = "Key"; 
        }
    }
}
