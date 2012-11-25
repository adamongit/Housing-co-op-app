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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the newMeetingMenuClick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void newMeetingMenuClick_Click(object sender, EventArgs e)
        {
            MeetingForm mf = new MeetingForm();
            mf.Owner = this;
            mf.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubgroupForm sf = new SubgroupForm();
            sf.Owner = this;
            sf.ShowDialog();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContractorForm cf = new ContractorForm(WindowOpenState.New);
            cf.Owner = this;
            cf.ShowDialog();
        }
    }

    /// <summary>
    /// Enum representing window state.
    /// </summary>
    public enum WindowOpenState
    {
        New,
        Edit,
        View
    }
}
