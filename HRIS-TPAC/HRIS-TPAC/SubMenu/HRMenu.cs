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
    public partial class HRMenu : Form
    {
        public HRMenu()
        {
            InitializeComponent();
        }

        private void btPPE001_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_PPE001.OpenFile();
        }

        private void btPPE002_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_PPE002.OpenFile();
        }

        private void btWPE001_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_WPE001.OpenFile();
        }

        private void btHRForms_Click(object sender, EventArgs e)
        {
            new HRFormsMenu().ShowDialog();
        }
    }
}
