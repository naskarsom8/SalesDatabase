using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Sales_Commission
{
    static class DateColumnIndex
    {
        internal static List<int> Datecolumns(DataGridView dgv)
        {
            List<int> datecols = new List<int>();

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name.ToLower().Contains("date") || col.Name.ToLower().Contains("month"))
                {
                    datecols.Add(col.Index+1);
                }
            }

            return datecols;
        }

        internal static List<int> Datecolumns(DataTable dt)
        {
            List<int> datecols = new List<int>();

            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName.ToLower().Contains("date") || col.ColumnName.ToLower().Contains("month"))
                {
                    datecols.Add(col.Ordinal+1);
                }
            }

            return datecols;
        }
    }
}
