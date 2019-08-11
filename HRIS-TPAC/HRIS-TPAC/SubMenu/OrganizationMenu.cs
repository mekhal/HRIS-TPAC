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
    public partial class OrganizationMenu : Form
    {
        public OrganizationMenu()
        {
            InitializeComponent();
        }

        private void btOC_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_OrganizationChart2019.OpenFile();
        }

        private void btHRD_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_HUMANRESOURCEDEPARTMENT.OpenFile();
        }

        private void btI1S_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_INJECTION1SECTION.OpenFile();
        }

        private void btI2S_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_INJECTION2SECTION.OpenFile();
        }

        private void btBM_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_BLOWMOLDINGTPAC2SECTION.OpenFile();
        }

        private void btPD2_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_PRUDUCTION2TPAC2SECTION.OpenFile();
        }

        private void btPD3_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_PRUDUCTION2TPAC3SECTION.OpenFile();
        }

        private void btIB_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_INJECTIONBLOWTPAC1.OpenFile();
        }

        private void btES_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_ENGINEERINGSECTION.OpenFile();
        }

        private void btRD_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_ResearchDevelopmentSECTION.OpenFile();
        }

        private void btMS_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_MOLDSECTION.OpenFile();
        }

        private void btDcc_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_DOCUMENTCONTROL.OpenFile();
        }

        private void btSD_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_SAFETYDEPARTMENT.OpenFile();
        }

        private void btSS_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_STORESECTION.OpenFile();
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_DELIVERYSECTION.OpenFile();
        }

        private void btPn_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_PLANINGSECTION.OpenFile();
        }

        private void btWH_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_WAREHOUSESECTION.OpenFile();
        }

        private void btPc_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_PURCHASESECTION.OpenFile();
        }

        private void btIT_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_ITSECTION.OpenFile();
        }

        private void btQA_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_QUALITYASSURANCEDEPARTMENT.OpenFile();
        }

        private void btFA_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_FinanceAdministrationDepartment.OpenFile();
        }

        private void btMD_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_MARKETING.OpenFile();
        }

        private void btBT3_Click(object sender, EventArgs e)
        {
            FilesHelper.HR_BLOWTPAC3SECTION.OpenFile();
        }
    }
}
