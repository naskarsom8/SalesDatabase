using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sales_Commission
{
    class TableColumns
    {
        internal DataTable ChangeHistoryCols(DataTable dt)
        {
            dt.Columns.Add("Info_Date", typeof(string));
            dt.Columns.Add("Table_Name", typeof(string));
            dt.Columns.Add("Change_Type", typeof(string));
            dt.Columns.Add("Audit_Trail", typeof(string));
            dt.Columns.Add("Change_Time", typeof(string));
            dt.Columns.Add("Editor", typeof(string));

            return dt;
        }

        internal DataSet FlexibleUploadCols(List<string> Columns)
        {
            DataTable dt = new DataTable("FlexibleUpload");
            DataSet ds = new DataSet("FlexibleUploadColumns");
            ds.Tables.Add(dt);
            dt.Columns.Add("SO_Number", typeof(long));
            dt.Columns.Add("Client_Name",typeof(string));
            foreach (string Cols in Columns)
            {
                switch(Cols)
                {
                    case "DM":
                        dt.Columns.Add("Old_DM", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "GSM":
                        dt.Columns.Add("Old_GSM", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "Memo_DM":
                        dt.Columns.Add("Old_Memo_DM", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "Memo_GSM":
                        dt.Columns.Add("Old_Memo_GSM", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "Country_Name":
                        dt.Columns.Add("GSM", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "Selling_CountryId":
                        dt.Columns.Add("GSM", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "GSM_Memo_Type":
                        dt.Columns.Add("Old_Memo_GSM", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "DM_Memo_Type":
                        dt.Columns.Add("Old_Memo_DM", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "Entry_Type":
                        dt.Columns.Add("Sale_Type",typeof(string));
                        dt.Columns.Add("Live_Status", typeof(string));
                        dt.Columns.Add("Adjustment_Id", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    case "ServiceName":
                        dt.Columns.Add("Product", typeof(string));
                        dt.Columns.Add("Product_Type", typeof(string));
                        dt.Columns.Add("Intensity_Lvl", typeof(string));
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                    default:
                        dt.Columns.Add(Cols, typeof(string));
                        break;
                }
            }
            dt.Columns.Add("AdjustmentStatus", typeof(string));
            return ds;
        }

        internal DataTable OrderDeletionCols(DataTable dt)
        {
            dt.Columns.Add("SO_Number", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("BU_Name", typeof(string));
            dt.Columns.Add("FromDate", typeof(string));
            dt.Columns.Add("ToDate", typeof(string));
            dt.Columns.Add("Delete_Comments", typeof(string));
            dt.Columns.Add("CorrectionType", typeof(string));
            dt.Columns.Add("User_Id", typeof(string));
            return dt;
        }
    }
}
