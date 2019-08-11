using ShortCuter.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShortCuter.SubMenu
{
    public partial class ITFormMenu : Form
    {
        public ITFormMenu()
        {
            InitializeComponent();
        }

        private void btFPE100_Click(object sender, EventArgs e)
        {
            FilesHelper.IT_FPE100.OpenFile();
        }

        private void btFPE110_Click(object sender, EventArgs e)
        {
            FilesHelper.IT_FPE110.OpenFile();
        }

        private void btFPE112_Click(object sender, EventArgs e)
        {
            FilesHelper.IT_FPE112.OpenFile();
        }

        private void btFPE113_Click(object sender, EventArgs e)
        {
            FilesHelper.IT_FPE113.OpenFile();
        }
    }
}
