using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Sales_Commission
{
    public partial class Extracts : Form
    {
        private DataAccess dac;
        DateTime frm, to;
        StatusBar ExtractStatusBar = new StatusBar();
        StatusBarPanel sbpRecordCount = new StatusBarPanel();
        StatusBarPanel sbpCTotal = new StatusBarPanel();
        StatusBarPanel sbpEmptypnl = new StatusBarPanel();

        //Extract form constructor.
        public Extracts()
        {
            InitializeComponent();
            dac = new DataAccess();
        }

        //Function to add status bar at the bottom of the form.
        private void AddStatusBar()
        {
            ExtractStatusBar.Panels.Remove(sbpEmptypnl);
            ExtractStatusBar.Panels.Remove(sbpRecordCount);
            ExtractStatusBar.Panels.Remove(sbpCTotal);
            try
            {
                int recordcnt = dgv_DataView_Extracts.Rows.Count;
                string cTotal = ValueObjects.ControlTotal(dgv_DataView_Extracts, cb_ExtractType_Ex.SelectedItem.ToString().ToLower());
                sbpEmptypnl.BorderStyle = StatusBarPanelBorderStyle.Sunken;
                sbpEmptypnl.Text = " ";
                sbpEmptypnl.ToolTipText = " ";
                sbpEmptypnl.AutoSize = StatusBarPanelAutoSize.Spring;
                ExtractStatusBar.Panels.Add(sbpEmptypnl);

                sbpCTotal.BorderStyle = StatusBarPanelBorderStyle.Sunken;
                sbpCTotal.Text = "Control Total: " + cTotal;
                sbpCTotal.ToolTipText = cTotal;
                sbpCTotal.AutoSize = StatusBarPanelAutoSize.Contents;
                ExtractStatusBar.Panels.Add(sbpCTotal);

                sbpRecordCount.BorderStyle = StatusBarPanelBorderStyle.Sunken;
                sbpRecordCount.Text = "Total Records: " + recordcnt.ToString();
                sbpRecordCount.ToolTipText = recordcnt.ToString();
                sbpRecordCount.AutoSize = StatusBarPanelAutoSize.Contents;
                ExtractStatusBar.Panels.Add(sbpRecordCount);

                ExtractStatusBar.ShowPanels = true;
                ExtractStatusBar.Font = new Font("Tahoma", 8, ExtractStatusBar.Font.Style);
                Controls.Add(ExtractStatusBar);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //View Extract button click event.
        private void btn_ViewExtract_Click(object sender, EventArgs e)
        {
            if (dtpckr_To_Ex.Value < dtpckr_From_Ex.Value)
            {
                MessageBox.Show("End Date cannot be less than Start Date.", "Date Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cb_BuName_Ex.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select an extract type and try again.", "No Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ViewData();
            }
        }

        //Function that extracts the data and views on the gridview
        private void ViewData()
        {
            if(rdbtn_DateProcessed_Ex.Checked == true)
            {
                ValueObjects.DateBasis = "Processed_Date";
            }
            else if(rdbtn_RollCallDate_Ex.Checked == true)
            {
                ValueObjects.DateBasis = "Rollcall_Date";
            }
            else
            {
                ValueObjects.DateBasis = "";
            }

            switch(cb_BuName_Ex.SelectedItem.ToString().ToLower())
            {
                case "streamline":
                case "global view":
                    ValueObjects.BUName = cb_BuName_Ex.SelectedItem.ToString();
                    break;
                default:
                    if (chkbx_MNC_Ex.Checked == true)
                    {
                        ValueObjects.BUName = "Combined";
                    }
                    else
                    {
                        ValueObjects.BUName = "Best of Breed";
                    }
                        break;
            }

            switch (cb_ExtractType_Ex.SelectedIndex)
            {
                //case 2:
                //    dgv_DataView_Extracts.DataSource = dac.GetExtracts(cb_ExtractType_Ex.SelectedIndex, cb_BuName_Ex.SelectedItem.ToString(), frm.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"),ValueObjects.DateBasis);
                //    ToolStrp_Extracts.Enabled = false;
                //    btn_GenerateExtract.Enabled = false;
                //    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    dgv_DataView_Extracts.DataSource = null;
                    frm = dtpckr_From_Ex.Value;
                    to = dtpckr_To_Ex.Value;
                    dgv_DataView_Extracts.DataSource = dac.GetExtracts(cb_ExtractType_Ex.SelectedIndex, cb_BuName_Ex.SelectedItem.ToString(), frm.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"), ValueObjects.DateBasis, ValueObjects.BUName);
                    rdbtn_DateProcessed_Ex.Checked = false;
                    rdbtn_RollCallDate_Ex.Checked = false;
                    //ToolStrp_Extracts.Enabled = true;
                    btn_GenerateExtract.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Please select an extract type before proceeding.", "Invalid Input.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ToolStrp_Extracts.Enabled = false;
                    btn_GenerateExtract.Enabled = false;
                    btn_ViewExtract_Adj.Enabled = false;
                    break;
            }
            AddStatusBar();
        }

        //Save to Excel  button click event.
        private void btn_GenerateExtract_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataTable)dgv_DataView_Extracts.DataSource).Copy();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            FastExportingMethod.ExportToExcel(ds, cb_ExtractType_Ex.SelectedItem.ToString(), DateColumnIndex.Datecolumns(dgv_DataView_Extracts));
            ValueObjects.ColumnNames = null;
        }

        //Extracts category combo box selection change event.
        private void cb_Extracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_ExtractType_Ex.SelectedIndex > 0)
            {
                if (cb_ExtractType_Ex.SelectedItem.ToString().ToUpper().Contains("IMPLEMENTATION"))
                {
                    cb_BuName_Ex.DataSource = null;
                    cb_BuName_Ex.Items.AddRange(new string[] { "","Date Processed", "Rollcall Date" });
                    grpbx_DateCriteria.Visible = false;
                    lbl_BUName_Ex.Text = "Date Basis";
                    chkbx_MNC_Ex.Visible = false;
                }
                else
                {
                    cb_BuName_Ex.DataSource = dac.GetBUNames(this.Name);
                    if(cb_ExtractType_Ex.SelectedItem.ToString().ToUpper().Contains("COMMISSION"))
                    {
                        grpbx_DateCriteria.Visible = false;
                        chkbx_MNC_Ex.Visible = false;
                    }
                    else
                    {
                        rdbtn_DateProcessed_Ex.Enabled = true;
                        grpbx_DateCriteria.Visible = true;
                        chkbx_MNC_Ex.Visible = true;
                    }
                    lbl_BUName_Ex.Text = "Business Unit";
                }

                cb_BuName_Ex.Enabled = true;
            }
            else
            {
                cb_BuName_Ex.Enabled = false;
                grpbx_DateCriteria.Visible = false;
                btn_ViewExtract_Adj.Enabled = false;
                chkbx_MNC_Ex.Visible = false;
                lbl_BUName_Ex.Text = "Business Unit";
            }
        }

        //Extract Type combo box selection change event.
        private void cb_ExtractType_Ex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cb_ExtractType_Ex.SelectedIndex > 1 && cb_BuName_Ex.SelectedIndex > 0)
            //{
            //    btn_ViewExtract_Adj.Enabled = true;
            //}
            //else
            //{
            //    btn_ViewExtract_Adj.Enabled = false;
            //}

            btn_ViewExtract_Adj.Enabled = cb_ExtractType_Ex.SelectedIndex > 1 && cb_BuName_Ex.SelectedIndex > 0 ? true : false;

            try
            {
                chkbx_MNC_Ex.Enabled = cb_BuName_Ex.SelectedItem.ToString() == "Streamline" || cb_BuName_Ex.SelectedItem.ToString() == "Global View" || cb_BuName_Ex.SelectedItem == null ? false : true;
                if (cb_BuName_Ex.SelectedItem.ToString() == "Streamline" || cb_BuName_Ex.SelectedItem.ToString() == "Global View" || cb_BuName_Ex.SelectedItem == null)
                { chkbx_MNC_Ex.Checked = false; }
            }
            catch(Exception ex)
            { }
        }

        //Extract form Load event.
        private void Extracts_Load(object sender, EventArgs e)
        {
            Accessiblity();
        }

        //Date Processed radio button check event.
        private void rdbtn_DateProcessed_Ex_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEnabler();
        }

        //Enable the view button.
        private void ButtonEnabler()
        {
            if (rdbtn_DateProcessed_Ex.Checked == true)
            {
                btn_ViewExtract_Adj.Enabled = true;
            }
            else if(rdbtn_RollCallDate_Ex.Checked == true)
            {
                btn_ViewExtract_Adj.Enabled = true;
            }
            else
            {
                btn_ViewExtract_Adj.Enabled = false;
            }
        }

        //Rollcall date radio button check event.
        private void rdbtn_RollCallDate_Ex_CheckedChanged(object sender, EventArgs e)
        {
            ButtonEnabler();
        }

        //include all the enability code here in accessibiltiy function.
        private void Accessiblity()
        {
            dtpckr_From_Ex.Format = DateTimePickerFormat.Short;
            dtpckr_To_Ex.Format = DateTimePickerFormat.Short;
            cb_ExtractType_Ex.SelectedIndex = 0;
            btn_GenerateExtract.Enabled = false;
            //ToolStrp_Extracts.Enabled = false;
            cb_BuName_Ex.Enabled = false;
            btn_ViewExtract_Adj.Enabled = false;
            grpbx_DateCriteria.Visible = false;
            toolStrpCb_Business_Ex.Items.Clear();
            chkbx_MNC_Ex.Visible = false;
            foreach(string s in dac.GetColumnNames("vw_Extract_MNC"))
            {
                toolStrpCb_Business_Ex.Items.Add(s);
            }
        }
    }
}
