using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShortCuter.Helper;

namespace ShortCuter.SubMenu
{
    public partial class LeaveMenu : Form
    {
        public LeaveMenu()
        {
            InitializeComponent();
        }

        private void btLeave_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Leave.OpenFile();
        }

        private void btSafety_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Safety.OpenFile();
        }

        private void btGuest_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Guest.OpenFile();
        }

        private void btUniform_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Uniform.OpenFile();
        }

        private void btLocker_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Locker.OpenFile();
        }
    }
}
