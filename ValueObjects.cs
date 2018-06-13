using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Sales_Commission
{
    static class ValueObjects
    {
        #region Name Holders

        private static string _sheetname, _msg, _colNames, _audittrail, _userid, _buName, _teamid, _segmentid, _roleid;
        private static bool _rtnValue;

        //excel SheetName storage
        public static string SheetName
        {
            get { return _sheetname; }
            set { _sheetname = value; }
        }

        public static string Msgboxheader
        {
            get { return _msg; }
            set { _msg = value; }
        }

        public static string ColumnNames
        {
            get { return _colNames; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _colNames = "";
                }
                else
                {
                    _colNames = value;
                }
            }
        }

        public static string AuditTrail
        {
            get { return _audittrail; }
            set { _audittrail = value; }
        }


        public static string DateBasis { get; set; }

        public static string TableName { get; set; }

        public static string AdjustmentStatus { get; set; }

        public static string QueryOperation { get; set; }

        public static string Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

        public static string BUName
        {
            get { return _buName; }
            set { _buName = value; }
        }

        public static int SalesTeamId { get; set; }

        public static int SegmentId { get; set; }

        public static int DesignationId { get; set; }

        public static string Message { get; set; }

        public static string TeamName { get; set; }

        public static string ReportingTo { get; set; }

        public static int PersonId { get; set; }

        public static bool ReturnValue
        {
            get { return _rtnValue; }
            set { _rtnValue = value; }
        }

        #endregion


        #region Functions

        public static DataTable FormatDateColumn(DataTable dt)
        {
            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName.ToLower().Contains("date"))
                {
                    dt.Columns[col.ColumnName].Convert(
                    val => DateTime.Parse(val.ToString()).ToString("dd/MM/yyyy"));
                }
            }

            return dt;
        }


        public static string ControlTotal(DataGridView dgv, string type)
        {
            double dCtrlTotal, dEmployees, dRPerAnnum, dRRevenue, dVPAE, dEAR, dSetup, dEOYCF;
            string[] columns;

            dCtrlTotal = 0;

            try
            {
                switch(type)
                {
                    case "sales report":
                        columns = new string[7];
                        columns[0] = "Employees";
                        columns[1] = "Runs_Per_Annum";
                        columns[2] = "Recurring_Revenue";
                        columns[3] = "Volume_Per_Annum/Entity";
                        columns[4] = "EAR";
                        columns[5] = "Setup";
                        columns[6] = "EOY/Country_Fee";
                        break;
                    case "implementation eod report":
                        columns = new string[7];
                        columns[0] = "Employees";
                        columns[1] = "Runs_Per_Annum";
                        columns[2] = "Recurring_Revenue";
                        columns[3] = "Volume_Per_Annum";
                        columns[4] = "EAR";
                        columns[5] = "Setup";
                        columns[6] = "EOY";
                        break;
                    default:
                        columns = new string[1];
                        columns[0] = "EAR";
                        break;
                }
                if(columns.Length > 1)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        dEmployees = (string.IsNullOrEmpty(row.Cells[columns[0].ToString()].Value.ToString())) ? 0 : Convert.ToDouble(row.Cells[columns[0].ToString()].Value.ToString());
                        dRPerAnnum = (string.IsNullOrEmpty(row.Cells[columns[1].ToString()].Value.ToString())) ? 0 : Convert.ToDouble(row.Cells[columns[1].ToString()].Value.ToString());
                        dRRevenue = (string.IsNullOrEmpty(row.Cells[columns[2].ToString()].Value.ToString())) ? 0 : Convert.ToDouble(row.Cells[columns[2].ToString()].Value.ToString());
                        dVPAE = (string.IsNullOrEmpty(row.Cells[columns[3].ToString()].Value.ToString())) ? 0 : Convert.ToDouble(row.Cells[columns[3].ToString()].Value.ToString());
                        dEAR = (string.IsNullOrEmpty(row.Cells[columns[4].ToString()].Value.ToString())) ? 0 : Convert.ToDouble(row.Cells[columns[4].ToString()].Value.ToString());
                        dSetup = (string.IsNullOrEmpty(row.Cells[columns[5].ToString()].Value.ToString())) ? 0 : Convert.ToDouble(row.Cells[columns[5].ToString()].Value.ToString());
                        dEOYCF = (string.IsNullOrEmpty(row.Cells[columns[6].ToString()].Value.ToString())) ? 0 : Convert.ToDouble(row.Cells[columns[6].ToString()].Value.ToString());

                        dCtrlTotal += Math.Round(dEmployees + dRPerAnnum + dRRevenue + dVPAE + dEAR + dSetup + dEOYCF, 2);

                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        dEAR = (string.IsNullOrEmpty(row.Cells[columns[0].ToString()].Value.ToString())) ? 0 : Convert.ToDouble(row.Cells["EAR"].Value.ToString());

                        dCtrlTotal += Math.Round(dEAR, 2);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ControlTotal Error.");
            }
            return dCtrlTotal.ToString();
        }

        public static string[] Abbreviator(string text)
        {
            string[] result = text.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            return result;
        }
        #endregion
    }
}
