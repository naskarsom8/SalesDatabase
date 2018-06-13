using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Commission
{
    public partial class frm_Adjustments : Form
    {

        Main form;
        DataAccess dac;
        DateTime from, To;

        //Adjustment form Constructor
        public frm_Adjustments()
        {
            InitializeComponent();
            dac = new DataAccess();
        }

        //Adjustment Form Load event.
        private void Custom_Template_Load(object sender, EventArgs e)
        {
            Accessiblity();
        }

        //Put all accessiblity codes here.
        private void Accessiblity()
        {
            btn_Gen_CTemplate.Enabled = false;
            pnl_SelectReset_CTemplate.Enabled = false;
            btn_Gen_CTemplate.Visible = false;

            cb_Month.Visible = false;
            cb_Year.Visible = false;
            dtp_From_CTemplate.Format = DateTimePickerFormat.Short;
            dtp_To_CTemplate.Format = DateTimePickerFormat.Short;
            cb_SelectCountry_CT.DataSource = dac.GetBUNames(this.Name);
            cb_AdjustmentType_Adj.SelectedIndex = 0;
            cb_Bunit_BT.SelectedIndex = 0;
            //btn_SaveExcel_BT.Enabled = false;
        }

        //List Check box values based on the Adjustment type selection.
        private void AdjustmentColumns()
        {
            chklstbx_AdjustmentColumns.Items.Clear();
            foreach (DataGridViewColumn col in dgv_DataView.Columns)
            {
                chklstbx_AdjustmentColumns.Items.Add(col.Name);
            }

            chklstbx_AdjustmentColumns.Items.RemoveAt(0);
        }

        //Function for the movement and exclusion of mandatory column values in list boxs.
        private void BlankTempColumns(int boxNumber)
        {
            if(boxNumber == 1)
            {
                lstbx_Cols_BT.Items.Clear();
                if (cb_Bunit_BT.SelectedItem.ToString() == "MNC")
                {
                    foreach (string s in dac.GetColumnNames("FlexibleUpload"))
                    {
                        if (s.ToLower() == "so_number" || s.ToLower() == "client_name" || s.ToLower() == "adjustmentstatus" || s.ToLower() == "bu_name" || s == "Old_GSM" || s == "Old_Memo_GSM" 
                            || s == "Old_Memo_DM" || s == "Old_DM" || s == "Old_Country_Name" || s == "Old_Selling_Country"|| s.ToLower() == "segmentname" || s.ToLower() == "rollcall_date" 
                            || s.ToLower() == "processed_date" || s.ToLower() == "old_selling_countryid" || s.ToLower() == "asm" || s.ToLower() == "sm" || s.ToLower() == "vp")
                        {
                            continue;
                        }
                        lstbx_Cols_BT.Items.Add(s);
                    }
                }
                else
                {
                    foreach (string s in dac.GetColumnNames("FlexibleUpload"))
                    {
                        if (s.ToLower() == "so_number" || s.ToLower() == "client_name" || s.ToLower() == "adjustmentstatus" || s.ToLower() == "bu_name" || s == "Memo_GSM" || s == "Memo_DM"
                            || s == "Selling_CountryId" || s == "Scope_CountryId" || s == "Country Fee" || s == "SL_Segment" || s == "GSM" || s == "Entity" || s == "DM_Memo_Type" || s == "GSM_Memo_Type" || 
                            s == "Old_GSM" || s == "Old_Memo_GSM" || s == "Old_Memo_DM" || s == "Old_DM" || s == "Old_Country_Name" || s.ToLower() == "old_selling_countryid" || s == "Country_Fee" || 
                            s.ToLower() == "segmentname" || s.ToLower() == "rollcall_date" || s.ToLower() == "processed_date")
                        {
                            continue;
                        }
                        lstbx_Cols_BT.Items.Add(s);
                    }
                }
                lstbx_Cols_BT.Sorted = true;
                lstbx_SelectedCols_BT.Items.Clear();
            }
            else
            {
                lstbx_SelectedCols_BT.Items.Clear();
                if(cb_Bunit_BT.SelectedItem.ToString() == "MNC")
                {
                    foreach (string s in dac.GetColumnNames("FlexibleUpload"))
                    {
                        if (s.ToLower() == "so_number" || s.ToLower() == "client_name" || s.ToLower() == "adjustmentstatus" || s.ToLower() == "bu_name" || s == "Old_GSM" || s == "Old_Memo_GSM"
                            || s == "Old_Memo_DM" || s == "Old_DM" || s == "Old_Country_Name" || s == "Old_Selling_Country" || s.ToLower() == "segmentname" || s.ToLower() == "rollcall_date"
                            || s.ToLower() == "processed_date" || s.ToLower() == "old_selling_countryid" || s.ToLower() == "asm" || s.ToLower() == "sm" || s.ToLower() == "vp")
                        {
                            continue;
                        }
                        lstbx_SelectedCols_BT.Items.Add(s);
                    }
                }
                else
                {
                    foreach (string s in dac.GetColumnNames("FlexibleUpload"))
                    {
                        if (s.ToLower() == "so_number" || s.ToLower() == "client_name" || s.ToLower() == "adjustmentstatus" || s.ToLower() == "bu_name" || s == "Memo_GSM" || s == "Memo_DM"
                            || s == "Selling_CountryId" || s == "Scope_CountryId" || s == "Country Fee" || s == "SL_Segment" || s == "GSM" || s == "Entity" || s == "DM_Memo_Type" || s == "GSM_Memo_Type" ||
                            s == "Old_GSM" || s == "Old_Memo_GSM" || s == "Old_Memo_DM" || s == "Old_DM" || s == "Old_Country_Name" || s.ToLower() == "old_selling_countryid" || s == "Country_Fee" 
                            || s.ToLower() == "segmentname" || s.ToLower() == "rollcall_date" || s.ToLower() == "processed_date")
                        {
                            continue;
                        }
                        lstbx_SelectedCols_BT.Items.Add(s);
                    }
                }
                lstbx_SelectedCols_BT.Sorted = true;
                lstbx_Cols_BT.Items.Clear();
            }
        }


        //Genereate button flase code.
        private void btn_Gen_CTemplate_Click(object sender, EventArgs e)
        {

        }

        //function to retrieve the column names from the checked list box.
        private void GetColNames()
        {
            for (int i = 0; i < chklstbx_AdjustmentColumns.Items.Count; i++)
            {
                if (chklstbx_AdjustmentColumns.GetItemCheckState(i) == CheckState.Checked)
                {
                    switch (i)
                    {
                        case 0:
                            if (chklstbx_AdjustmentColumns.Items[0].ToString() == "Setup")
                            {
                                ValueObjects.ColumnNames += "S.Set_Up_Value_Of_Split as [Setup], ";
                            }
                            else
                            {
                                ValueObjects.ColumnNames += "Legal_Entity, ";
                            }
                            break;
                        case 1:
                            if (chklstbx_AdjustmentColumns.Items[1].ToString() == "Recurring Revenue")
                            {
                                ValueObjects.ColumnNames += "SO.Recurring_Revenue as [Recurring Revenue], ";
                            }
                            else
                            {
                                ValueObjects.ColumnNames += "PayrollNo_CUID as [PayrollNo or CUID], ";
                            }
                            break;
                        case 2:
                            if (chklstbx_AdjustmentColumns.Items[2].ToString() == "EOY")
                            {
                                ValueObjects.ColumnNames += "SO.EOY, ";
                            }
                            else
                            {
                                ValueObjects.ColumnNames += "Group_Code, ";
                            }
                            break;
                        case 3:
                            if (chklstbx_AdjustmentColumns.Items[3].ToString() == "Float")
                            {
                                ValueObjects.ColumnNames += "So.Float, ";
                            }
                            else
                            {
                                ValueObjects.ColumnNames += "Live_Status, ";
                            }
                            break;
                        case 4:
                            ValueObjects.ColumnNames += "So.FX, ";
                            break;
                        case 5:
                            ValueObjects.ColumnNames += "S.EAR_Value_Of_Split as EAR, ";
                            break;
                        case 6:
                            ValueObjects.ColumnNames += "So.Employees, ";
                            break;
                        case 7:
                            ValueObjects.ColumnNames += "So.Runs_per_Annum as Frequency, ";
                            break;
                        case 8:
                            ValueObjects.ColumnNames += "So.Volume_Per_Annum as [Volume Per Annum], ";
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        //Move all columns to Selected column list box button click event - Blank Template.
        private void btn_MoveAllCols_BT_Click(object sender, EventArgs e)
        {
            if(lstbx_Cols_BT.SelectedItems.Count > 1)
            {
                foreach(string s in lstbx_Cols_BT.SelectedItems)
                {
                    lstbx_SelectedCols_BT.Items.Add(s);
                }

                foreach (string s in lstbx_SelectedCols_BT.Items)
                {
                    lstbx_Cols_BT.Items.Remove(s);
                    lstbx_SelectedCols_BT.Sorted = true;
                }
            }
            else
            {
                    BlankTempColumns(2);
            }
        }

        //Move all columns back to selection list box button click event - Blank Template.
        private void btn_MoveBackCols_BT_Click(object sender, EventArgs e)
        {
            if(lstbx_SelectedCols_BT.SelectedItems.Count > 1)
            {
                foreach(string s in lstbx_SelectedCols_BT.SelectedItems)
                {
                    lstbx_Cols_BT.Items.Add(s);
                }

                foreach (string s in lstbx_Cols_BT.Items)
                {
                    lstbx_SelectedCols_BT.Items.Remove(s);
                    lstbx_Cols_BT.Sorted = true;
                }
            }
            else
            {
                    BlankTempColumns(1);
            }
        }

        //Save to Excel button click event - Custom Template.
        private void btn_Generate_CTemplate_Click(object sender, EventArgs e)
        {
            from = dtp_From_CTemplate.Value;
            To = dtp_To_CTemplate.Value;
            DataSet ds = new DataSet();
            ds.Tables.Add(dgv_DataView.DataSource as DataTable);
            FastExportingMethod.ExportToExcel(ds, cb_AdjustmentType_Adj.SelectedItem.ToString() + "_FlexibleUpload", DateColumnIndex.Datecolumns(ds.Tables[0]));
            ValueObjects.ColumnNames = null;
        }

        //Adjustment Type combo box selection change event - Custom Template.
        private void cb_AdjustmentType_Adj_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueObjects.SheetName = cb_AdjustmentType_Adj.SelectedItem.ToString();
            if (cb_AdjustmentType_Adj.SelectedIndex < 1)
            {
                pnl_SelectReset_CTemplate.Enabled = false;
            }
        }
        
        //Select all radio button check event - Custom Template.
        private void rdbtn_CheckAll_Adj_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstbx_AdjustmentColumns.Items.Count; i++)
            {
                chklstbx_AdjustmentColumns.SetItemChecked(i, true);
            }
        }

        //Reset radio button check event - Custom Template.
        private void rdbtn_Reset_Adj_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chklstbx_AdjustmentColumns.Items.Count; i++)
            {
                chklstbx_AdjustmentColumns.SetItemChecked(i, false);
            }
        }

        //Move 1 column to Selected column list box button click event - Blank Template.
        private void btn_Move1Col_BT_Click(object sender, EventArgs e)
        {
            if(lstbx_Cols_BT.SelectedIndex < 0)
            {
                lstbx_Cols_BT.SetSelected(0, true);
                lstbx_SelectedCols_BT.Items.Add(lstbx_Cols_BT.SelectedItem);

                foreach (string s in lstbx_SelectedCols_BT.Items)
                {
                    lstbx_Cols_BT.Items.Remove(s);
                    lstbx_SelectedCols_BT.Sorted = true;
                }
            }

            else
            {
                lstbx_SelectedCols_BT.Items.Add(lstbx_Cols_BT.SelectedItem);

                foreach (string s in lstbx_SelectedCols_BT.Items)
                {
                    lstbx_Cols_BT.Items.Remove(s);
                    lstbx_SelectedCols_BT.Sorted = true;
                }
            }

        }

        //Move 1 column back to Selection List box button click event - Blank Template
        private void btn_Move1ColBack_Bt_Click(object sender, EventArgs e)
        {
            if(lstbx_SelectedCols_BT.SelectedIndex < 0)
            {
                lstbx_SelectedCols_BT.SetSelected(0, true);
                lstbx_Cols_BT.Items.Add(lstbx_SelectedCols_BT.SelectedItem);

                foreach (string s in lstbx_Cols_BT.Items)
                {
                    lstbx_SelectedCols_BT.Items.Remove(s);
                    lstbx_Cols_BT.Sorted = true;
                }
            }
            else
            {
                lstbx_Cols_BT.Items.Add(lstbx_SelectedCols_BT.SelectedItem);

                foreach (string s in lstbx_Cols_BT.Items)
                {
                    lstbx_SelectedCols_BT.Items.Remove(s);
                    lstbx_Cols_BT.Sorted = true;
                }
            }
        }

        //Business Unit combo box selection change event - Blank Template.
        private void cb_Bunit_BT_SelectedIndexChanged(object sender, EventArgs e)
        {
            BlankTempColumns(1);
        }

        //Save to Excel button click event - Blank Template.
        private void btn_SaveExcel_BT_Click(object sender, EventArgs e)
        {
            TableColumns cols = new TableColumns();
            FastExportingMethod.ExportToExcel(cols.FlexibleUploadCols(lstbx_SelectedCols_BT.Items.OfType<string>().ToList()),"FlexibleUpload");
            
        }

        //Selected Column list box selection event - Blank Template.
        private void lstbx_SelectedCols_BT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //View data button - Custom Template.
        private void btn_View_CTemplate_Click_1(object sender, EventArgs e)
        {
            from = dtp_From_CTemplate.Value;
            To = dtp_To_CTemplate.Value;
            dgv_DataView.DataSource = null;
            //GetColNames();

            switch (cb_AdjustmentType_Adj.SelectedItem.ToString().ToUpper())
            {
                case "AUDIT":
                case "NO STARTS":
                case "RESTARTS":
                case "OTHERS":
                    if (ValueObjects.ColumnNames == null)
                    {
                        ValueObjects.ColumnNames = "123";
                        dgv_DataView.DataSource = dac.GetAdjustmentDetails(cb_AdjustmentType_Adj.SelectedIndex, cb_SelectCountry_CT.SelectedItem.ToString(), from.ToString("yyyy-MM-dd"), To.ToString("yyyy-MM-dd"));
                        //lbl_RowCount_CTemplate.Visible = true;
                        //lbl_RowCount_CTemplate.Text = "Total Rows: " + (dgv_DataView.Rows.Count - 1).ToString();
                    }
                    else
                    {
                        dgv_DataView.DataSource = dac.GetAdjustmentDetails(cb_AdjustmentType_Adj.SelectedIndex, cb_SelectCountry_CT.SelectedItem.ToString(), from.ToString("yyyy-MM-dd"), To.ToString("yyyy-MM-dd"));
                    }
                    break;
                default:
                    break;
            }
            AdjustmentColumns();
            pnl_SelectReset_CTemplate.Enabled = true;
            ValueObjects.ColumnNames = null;
        }

    }

}
