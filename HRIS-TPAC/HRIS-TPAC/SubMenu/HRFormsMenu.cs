using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using ShortCuter.Helper;

namespace ShortCuter.SubMenu
{
    public partial class HRFormsMenu : Form
    {
        public HRFormsMenu()
        {
            InitializeComponent();
        }

        private void btFPE003_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_FPE003.OpenFile();
        }

        private void btFPE013_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_FPE013.OpenFile();
        }

        private void btFPE018_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_FPE018.OpenFile();
        }

        private void btForm_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_Leaveform.OpenFile();
        }
    }
}
