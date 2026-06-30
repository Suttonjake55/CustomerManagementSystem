using JacobSutton_C989.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSutton_C989
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void ApptMonth_btn_Click(object sender, EventArgs e)
        {
            Reporting report = new Reporting();

            List<Reporting> data = report.GetReportData();

            var newReport = report.AppointmentTypeByMonth(data);
            Reports_dgv.Columns.Clear();
            Reports_dgv.DataSource = newReport;
        }

        private void UserSchedule_btn_Click(object sender, EventArgs e)
        {
            Reporting report = new Reporting();

            List<Reporting> data = report.GetReportData();

            var newReport = report.UserSchedule(data, LoggedInUser.LoggedIn);

            Reports_dgv.Columns.Clear();
            Reports_dgv.DataSource = newReport;
        }

        private void UserLocation_btn_Click(object sender, EventArgs e)
        {
            Reporting report = new Reporting();

            List<Reporting> data = report.GetReportData();

            var newReport = report.LocationReport(data);

            Reports_dgv.Columns.Clear();
            Reports_dgv.DataSource = newReport;
        }
    }
}
