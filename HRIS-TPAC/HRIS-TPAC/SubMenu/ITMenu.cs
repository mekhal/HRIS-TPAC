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
    public partial class ITMenu : Form
    {
        public ITMenu()
        {
            InitializeComponent();
        }

        private void btGPO_Click(object sender, EventArgs e)
        {
            FilesHelper.IT_GroupPolicy.OpenFile();
        }

        private void btStandard_Click(object sender, EventArgs e)
        {
            FilesHelper.IT_SWTemplate.OpenFile();
        }

        private void btForm_Click(object sender, EventArgs e)
        {
            new ITFormMenu().ShowDialog();
        }
    }
}
