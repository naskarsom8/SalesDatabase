using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Sales_Commission
{
    public partial class Sales_Hierarchy_New : Form
    {

        DataAccess dac;
        Add_SalesTeam AddSalesteam;
        Add_SegmentName AddSegmentname ;
        

        public Sales_Hierarchy_New()
        {
            InitializeComponent();
            dac = new DataAccess();
            AddSalesteam = new Add_SalesTeam();
            AddSegmentname = new Add_SegmentName();

            cb_HierBusinessunit.DataSource = dac.GetBUNames();
            cb_Country_hierNew.DataSource = dac.GetBUNames();
            cb_Designation_Hiernew.DataSource = dac.GetDesignations();
            cb_Salesteamname_Hiernew.DataSource = dac.GetSalesTeams();
            cb_segmentname_hiernew.DataSource = dac.GetSegments();

        }

       
       
        private bool Mandatoryfields()
        {
            if(textBox_Personid_hiernew.Text == string.Empty|textBox_Name_hiernew.Text==string.Empty|
               string.IsNullOrWhiteSpace(textBox_Personid_hiernew.Text)|string.IsNullOrWhiteSpace(textBox_Name_hiernew.Text))
            {
                return false;
            } 
            else
            {
                return true;
            }

        }

        private void btn_Add_HierNew_Click(object sender, EventArgs e)
        {
            
            if(Mandatoryfields() ==false)
            {
                MessageBox.Show("Mandatory fields are marked as '*' which cannot be blank. \n Please select/Enter the values for the mandatory fields.");
            }

            else
            {
                MessageBox.Show("Done");
            }
            textBox_Personid_hiernew.Clear();
            textBox_Name_hiernew.Clear();

        }

        private void linkLabel_AddSalesteam_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSalesteam.ShowDialog();
        }

        private void linkLabel_AddSegmentname_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSegmentname.ShowDialog();
        }

        private void btn_BlankTempHier_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();

            if (excel == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = excel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Name = "Hierarchy Upload";

            xlWorkSheet.Cells[1, 1] = "Person ID";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[1, 3] = "Designation";
            xlWorkSheet.Cells[1, 4] = "Reporting To";
            xlWorkSheet.Cells[1, 5] = "Sales Team Name";
            xlWorkSheet.Cells[1, 6] = "Segment Name";

            xlWorkSheet.Cells[1, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            xlWorkSheet.Cells[1, 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            xlWorkSheet.Cells[1, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            xlWorkSheet.Cells[1, 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            xlWorkSheet.Cells[1, 5].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            xlWorkSheet.Cells[1, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);


            excel.Visible = true;
            excel.UserControl = true;
        }
        
    }
}
