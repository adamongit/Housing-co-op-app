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
using System.Data.Linq;
using BusinessObjects;

namespace HousingCoopAppWinForms
{
    public partial class MeetingsViewerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingsViewerForm" /> class.
        /// </summary>
        public MeetingsViewerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MeetingsViewerForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void MeetingsViewerForm_Load(object sender, EventArgs e)
        {
            MeetingDataContext mdc = new MeetingDataContext(
                ConfigurationManager.ConnectionStrings["hamwicConnectionString"].ConnectionString);

            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<Subgroup>(s => s.Name);
            dlo.AssociateWith<Subgroup>(s => s.Name);
            mdc.LoadOptions = dlo;
            
            var meetings = from m in mdc.Meetings
                           from s in mdc.Subgroups
                           select new
                           {
                               m.Id,
                               m.Location_,
                               s.Name,
                               m.DateTimeFrom,
                               m.DateTimeTo
                           };
            SetupDataGridView(meetings);
        }

        /// <summary>
        /// Setups the data grid view.
        /// </summary>
        /// <param name="meetings">The meetings.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void SetupDataGridView(object meetings)
        {
            this.dgvMeetingsDataGridView.DataSource = meetings;
            this.dgvMeetingsDataGridView.Columns["Id"].Visible = false;
            this.dgvMeetingsDataGridView.Columns["Name"].HeaderText = "Subgroup Name";
            this.dgvMeetingsDataGridView.Columns["Location_"].HeaderText = "Location";
            this.dgvMeetingsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
