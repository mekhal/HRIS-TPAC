using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShortCuter.SubMenu;
using ShortCuter.Helper;

namespace HRISTPAC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btHRPolicy_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Policy.OpenFile();
        }

        private void btOrgainzation_Click(object sender, EventArgs e)
        {
            new OrganizationMenu().ShowDialog();
        }

        private void btHRHoliday_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Holiday.OpenFile();
        }

        private void btRoles_Click(object sender, EventArgs e)
        {
            new LeaveMenu().ShowDialog();
        }

        private void btHR_Click(object sender, EventArgs e)
        {
            new HRMenu().ShowDialog();
        }

        private void btTraining_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_TrainingPlan.OpenFile();
        }

        private void btIT_Click(object sender, EventArgs e)
        {
            new ITMenu().ShowDialog();
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Email.OpenFile();
        }

        private void btTel_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Tel.OpenFile();
        }
    }
}
