using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShortCuter.Helper
{
    public static class FilesHelper
    {
        public static string RootFolder = "T:";

        public static string HR = $@"{RootFolder}\HR";
        public static string HR_Policy = $@"{HR}\ข้อบังคับเกี่ยวกับการทำงาน.pdf";
        public static string HR_Holiday = $@"{HR}\วันหยุดประเพณี 2562.pdf";
        public static string HR_Email = $@"{HR}\E-Mail.xlsx";
        public static string HR_Tel = $@"{HR}\เบอร์โทรภายในA4.pdf";
        public static string HR_OrganizationChart2019 = "";
        public static string HR_HUMANRESOURCEDEPARTMENT = $@"{HR}\HR.pdf";
        public static string HR_INJECTION1SECTION = $@"{HR}\INJ1.pdf";
        public static string HR_INJECTION2SECTION = $@"{HR}\INJ2.pdf";
        public static string HR_BLOWMOLDINGTPAC2SECTION = $@"{HR}\BLOW2.pdf";
        public static string HR_PRUDUCTION2TPAC2SECTION = $@"{HR}\PD2TPAC2.pdf";
        public static string HR_PRUDUCTION2TPAC3SECTION = $@"{HR}\PD2TPAC3.pdf";
        public static string HR_INJECTIONBLOWTPAC1 = $@"{HR}\PET.pdf";
        public static string HR_ENGINEERINGSECTION = $@"{HR}\ENGINEER.pdf";
        public static string HR_ResearchDevelopmentSECTION = $@"{HR}\R&D.pdf";
        public static string HR_MOLDSECTION = $@"{HR}\MOLD.pdf";
        public static string HR_DOCUMENTCONTROL = $@"{HR}\DCC.pdf";
        public static string HR_SAFETYDEPARTMENT = $@"{HR}\SAFETY.pdf";
        public static string HR_STORESECTION = $@"{HR}\STORE.pdf";
        public static string HR_DELIVERYSECTION = $@"{HR}\DELIVERY.pdf";
        public static string HR_PLANINGSECTION = $@"{HR}\PLANNING.pdf";
        public static string HR_WAREHOUSESECTION = $@"{HR}\WAREHOUSE.pdf";
        public static string HR_PURCHASESECTION = $@"{HR}\PC.pdf";
        public static string HR_ITSECTION = $@"{HR}\IT.pdf";
        public static string HR_QUALITYASSURANCEDEPARTMENT = $@"{HR}\QA.pdf";
        public static string HR_FinanceAdministrationDepartment = $@"{HR}\AC&FN.pdf";
        public static string HR_MARKETING  = $@"{HR}\MKT.pdf";
        public static string HR_BLOWTPAC3SECTION = $@"{HR}\BLOW3.pdf";
        public static string HR_Leave = $@"{HR}\ระเบียบปฏิบัติ เรื่อง  ชี้แจงเพิ่มเติมจากระเบียบข้อบังคับในการลากิจ ลาป่วย ลาพักร้อน และอื่นๆ.pdf";
        public static string HR_Safety = $@"{HR}\ระเบียบปฏิบัติ  เรื่อง การป้องกันการปนเปื้อนจากเส้นผม.pdf";
        public static string HR_Guest = $@"{HR}\ระเบียบปฎิบัติ การเข้า-ออกบุคคลภายนอก.pdf";
        public static string HR_Uniform = $@"{HR}\ระเบียบปฏิบัติ  การแต่งกาย พนักงาน TPAC.pdf";
        public static string HR_Locker = $@"{HR}\ระเบียบการใช้ตู้ล็อคเกอร์.pdf";
        public static string HR_PPE001 = $@"{HR}\P-PE-001 R.08 การสรรหา.pdf";
        public static string HR_PPE002 = $@"{HR}\P-PE-002 R.09 การฝึกอบรม.pdf";
        public static string HR_WPE001 = $@"{HR}\W-PE-001 R.06 การสัมภาษณ์.pdf";
        public static string HR_FPE003 = $@"{HR}\F-PE-003 ใบขอกำลังพล.pdf";
        public static string HR_FPE013 = $@"{HR}\F-PE-013 ใบขอฝึกอบรม-แบบประเมินอบรมนอกสถานที่.pdf";
        public static string HR_FPE018 = $@"{HR}\แบบฟอร์มขออนุมัติฝึกอบรม-สัมมนาภายใน.pdf";
        public static string HR_Leaveform = $@"{HR}\ใบขออนุมัติลาหยุดงาน.pdf";
        public static string HR_TrainingPlan = $@"{HR}\โปรแกรมการฝึกอบรมประจำเดือน.xls";

        public static string IT = $@"{RootFolder}\IT";
        public static string IT_GroupPolicy = $@"{IT}\GroupPolicy.pdf";
        public static string IT_SWTemplate = $@"{IT}\SW_Template.pdf";
        public static string IT_FPE100 = $@"{IT}\F-PE-100 (R05) การบริการและแจ้งซ่อมทางด้านคอมพิวเตอร์.pdf";
        public static string IT_FPE110 = $@"{IT}\F-PE-110 (R01) ERP Service.pdf";
        public static string IT_FPE112= $@"{IT}\F-PE-112 (R00) แบบฟอร์มขอสิทธิ์การใช้งาน เครือข่าย และ อินเตอร์เน็ต บุคคลภายนอก.pdf";
        public static string IT_FPE113 = $@"{IT}\F-PE-113 (R00) แบบฟอร์มขอสิทธิ์การใช้งาน เครือข่ายเครือข่ายส่วนตัวเสมือนระยะไกล.pdf";

        public static void OpenFile(this string filePath) {

            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("ไม่พบไฟล์ข้อมูล กรุณาติดต่อผู้ดูแลระบบ", "Error - File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Process.Start(filePath);
                }
            }
            catch {
                MessageBox.Show("ไม่สามารถเปิดไฟล์ข้อมูล กรุณาติดต่อผู้ดูแลระบบ", "Error - Can not open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
