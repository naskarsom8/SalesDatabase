using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sales_Commission
{
    public partial class Flexible_Upload : Form
    {
        private DataAccess dac;
        private DataTable dt;

        //Flexible Upload Constructor.
        public Flexible_Upload()
        {
            InitializeComponent();
            dac = new DataAccess();
        }
        
        //Browse button code.
        private void btn_Browse_FU_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowNewFolderButton = true;

            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            ofd.Filter = "MS Excel Worksheet (*.xlsx, *.xls) | *.xlsx; *.xls";
            if(cb_AdjTypeUpload_FU.SelectedIndex > 0)
            {
                ValueObjects.AdjustmentStatus = cb_AdjTypeUpload_FU.SelectedItem.ToString();
            }
            else
            {
                ValueObjects.AdjustmentStatus = null;
            }

            if (result == DialogResult.OK)
            {
                dt = FastImportingExcelPackage.ImportSheet(ofd.FileName);

                dt = ValueObjects.FormatDateColumn(dt);

                dgv_DataView_FU.DataSource = dt;

                if((!string.IsNullOrEmpty(ValueObjects.AdjustmentStatus)) && dgv_DataView_FU.Rows.Count >= 1)
                {
                    for (int i = 0; i < dgv_DataView_FU.Rows.Count; i++)
                    {
                        dgv_DataView_FU.Rows[i].Cells["AdjustmentStatus"].Value = ValueObjects.AdjustmentStatus;
                        btn_Upload_FU.Enabled = true;
                    }
                }
               else if (dgv_DataView_FU.Rows.Count >= 1)
                {
                    btn_Upload_FU.Enabled = true;
                }
                else
                {
                    btn_Upload_FU.Enabled = false;
                }

                txt_Upload_Summary.Text = "SUMMARY:" + Environment.NewLine + Environment.NewLine + "Number of records: " + (dgv_DataView_FU.Rows.Count).ToString();
                //txt_Upload_Summary.Text += Environment.NewLine + "Control_Total" + ValueObjects.ControlTotal(dgv_DataView_FU).ToString();
                txt_Upload_Summary.Visible = true;
                ValueObjects.AdjustmentStatus = null;
            }
        }

        //Flexible Upload Page Load.
        private void Flexible_Upload_Load(object sender, EventArgs e)
        {
            Accessibility();
        }

        //include all the enability code here in accessibiltiy function.
        private void Accessibility()
        {
            btn_Upload_FU.Enabled = false;
            txt_Upload_Summary.Visible = false;
            txt_Browse_FU.Enabled = false;
            btn_Browse_FU.Enabled = false;
            cb_Country_FxUpload.Enabled = false;
            cb_Country_FxUpload.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Country_FxUpload.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_UploadType_FxUpload.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_UploadType_FxUpload.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Country_FxUpload.DataSource = dac.GetBUNames(this.Name);
            cb_UploadType_FxUpload.SelectedIndex = 0;
            lbl_AdjType_FU.Visible = false;
            cb_AdjTypeUpload_FU.Visible = false;
            cb_AdjTypeUpload_FU.Enabled = false;

            foreach (string s in dac.GetColumnNames("FlexibleUpload"))
            {
                if (s.ToLower() == "so_number" || s.ToLower() == "client_name" || s.ToLower() == "adjustmentstatus" || s.ToLower() == "dm" || s.ToLower() == "country_name" || s.ToLower() == "gsm"
                    || s.ToLower() == "memo_dm" || s.ToLower() == "memo_gsm" || s.ToLower() == "selling_countryid" || s.ToLower() == "gsm_memo_type" || s.ToLower() == "dm_memo_type" || s.ToLower() == "old_dm"
                    || s.ToLower() == "old_gsm" || s.ToLower() == "scope_countryid" || s.ToLower() == "old_memo_dm" || s.ToLower() == "old_memo_gsm" || s.ToLower() == "old_country_name"
                    || s.ToLower() == "old_selling_countryid" || s.ToLower() == "processed_date" || s.ToLower() == "rollcall_date" || s.ToLower() == "entry_type" || s.ToLower() == "bu_name" 
                    || s.ToLower() == "segmentname" || s.ToLower() == "servicename" || s.ToLower() == "asm" || s.ToLower() == "sm" || s.ToLower() == "vp")
                {
                    continue;
                }
                else
                {
                    cb_AdjTypeUpload_FU.Items.Add(s);
                }
                
            }

        }

        //Upload button code.
        private void btn_Upload_FU_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ValueObjects.AuditTrail = "Client Name: ";
            dt = dgv_DataView_FU.DataSource as DataTable;
            ValueObjects.TableName = "Upload";
            bool rtnvalue = false;

            switch (cb_UploadType_FxUpload.SelectedIndex)
            {
                case 2:
                    if (MessageBox.Show("You are updating " + dgv_DataView_FU.Rows.Count + " records. Are you sure you want to proceed with the updation?", "Record update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        dac.InsertFlexibleUpload(dgv_DataView_FU.DataSource as DataTable, "FlexibleUpload", 100);
                        ValueObjects.TableName = "FlexibleUpload";
                        ValueObjects.QueryOperation = "Update";
                    }
                    else
                    {
                        MessageBox.Show("Update was successfully aborted. No records updated in the database.", "Cancelled Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    switch (cb_Country_FxUpload.SelectedItem.ToString().ToLower())
                    {
                        case "streamline":
                            rtnvalue = dac.InsertOrdersUpload(dgv_DataView_FU.DataSource as DataTable, "dbo.SL", 10) == true ? true : false;
                            ValueObjects.QueryOperation = "Insert";
                            ValueObjects.TableName = "dbo.SL";
                            break;
                        case "global view":
                            rtnvalue = dac.InsertOrdersUpload(dgv_DataView_FU.DataSource as DataTable, "dbo.MNC", 10) == true ? true : false;
                            ValueObjects.QueryOperation = "Insert";
                            ValueObjects.TableName = "dbo.MNC";
                            break;
                        case "united kingdom - cpq":
                            rtnvalue = dac.InsertOrdersUpload(dgv_DataView_FU.DataSource as DataTable, "dbo.UK_Upload", 10) == true ? true : false;
                            ValueObjects.QueryOperation = "Insert";
                            ValueObjects.TableName = "dbo.UK_Upload";
                            break;
                        case "2sp":
                        case "spain":
                        case "poland":
                        case "switzerland":
                        case "italy":
                        case "germany":
                            rtnvalue = dac.InsertOrdersUpload(dgv_DataView_FU.DataSource as DataTable, "dbo.SP", 10) == true ? true : false;
                            ValueObjects.QueryOperation = "Insert";
                            ValueObjects.TableName = "dbo.SP";
                            break;
                        default:
                            if (dac.GetUploadDetails(cb_Country_FxUpload.SelectedItem.ToString().ToLower(), dt) == true)
                            {
                                ValueObjects.QueryOperation = "Insert";
                                ValueObjects.TableName = "Sales Order";
                                rtnvalue = true;
                            }
                            else
                            {
                                ValueObjects.QueryOperation = "";
                                ValueObjects.TableName = "";
                                rtnvalue = false;
                            }
                            break;
                    }
                    break;
            }

            if (dgv_DataView_FU.Rows.Count >= 1 && (!string.IsNullOrEmpty(ValueObjects.TableName)))
            {
                string columnName = null;
                try
                {
                    for (int i = 0; i < dgv_DataView_FU.Columns.Count; i++)
                    {
                        if (dgv_DataView_FU.Columns[i].Name.ToLower().Contains("client"))
                        {
                            if (dgv_DataView_FU.Columns[i].Name.ToLower().Contains(" "))
                            {
                                columnName = Regex.Replace(dgv_DataView_FU.Columns[i].Name, " ", "");
                            }
                            else
                            {
                                columnName = Regex.Replace(dgv_DataView_FU.Columns[i].Name, "_", "");
                            }

                            columnName = columnName == "ClientName" ? columnName = dgv_DataView_FU.Columns[i].Name : columnName = "Client_Name";
                            break;
                        }
                    }
                    foreach (DataGridViewRow row in dgv_DataView_FU.Rows)
                    {
                        ValueObjects.AuditTrail += row.Cells[columnName].Value.ToString() + ", ";
                    }

                   dac.InsertChangeHistory(cb_UploadType_FxUpload.SelectedItem.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), ValueObjects.TableName, ValueObjects.QueryOperation, ValueObjects.AuditTrail, DateTime.Now.ToLongTimeString(), Environment.UserName);
                   if(rtnvalue == true)
                    {
                        MessageBox.Show(dgv_DataView_FU.Rows.Count + " Records updated succesfully.");
                    }
                   else
                    {
                        MessageBox.Show("No Records were updated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Upload Error");
                }
            }
            btn_Upload_FU.Enabled = false;
            txt_Upload_Summary.Visible = false;

            dgv_DataView_FU.DataSource = null;
            dgv_DataView_FU.Refresh();
        }

        //Upload combo box type selection code.
        private void cb_UploadType_FxUpload_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_UploadType_FxUpload.SelectedIndex)
            {
                case 1:
                    cb_Country_FxUpload.Enabled = true;
                    lbl_AdjType_FU.Visible = false;
                    cb_AdjTypeUpload_FU.Visible = false;
                    cb_AdjTypeUpload_FU.SelectedIndex = 0;
                    break;
                case 2:
                    cb_Country_FxUpload.Enabled = true;
                    lbl_AdjType_FU.Visible = true;
                    cb_AdjTypeUpload_FU.Visible = true;
                    break;
                default:
                    cb_Country_FxUpload.Enabled = false;
                    txt_Browse_FU.Enabled = false;
                    btn_Browse_FU.Enabled = false;
                    lbl_AdjType_FU.Visible = false;
                    cb_AdjTypeUpload_FU.Visible = false;
                    cb_Country_FxUpload.SelectedIndex = 0;
                    cb_AdjTypeUpload_FU.SelectedIndex = 0;
                    break;
            }

        }
        
        //Country combo box value selection code.
        private void cb_Country_FxUpload_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_Country_FxUpload.SelectedIndex)
            {
                case 0:
                    txt_Browse_FU.Enabled = false;
                    btn_Browse_FU.Enabled = false;
                    cb_AdjTypeUpload_FU.Enabled = false;
                    cb_AdjTypeUpload_FU.SelectedIndex = 0;
                    break;

                default:
                    switch(cb_UploadType_FxUpload.SelectedIndex)
                    {
                        case 2:
                            cb_AdjTypeUpload_FU.Enabled = true;
                            txt_Browse_FU.Enabled = true;
                            btn_Browse_FU.Enabled = true;
                            break;
                        default:
                            txt_Browse_FU.Enabled = true;
                            btn_Browse_FU.Enabled = true;
                            break;
                    }
                    break;
            }
        }
    }
}

/// <summary>
/// Extension Method Class that converts a column data to datetime datatype.
/// </summary>
public static class DataCololumnExtensionMethod
{
    public static void Convert<T>(this DataColumn column, Func<object, T> conversion)
    {
        foreach (DataRow row in column.Table.Rows)
        {
            row[column] = conversion(row[column]);
        }
    }
}