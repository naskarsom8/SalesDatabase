using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data;

namespace Sales_Commission
{
    static class FastImportingMethod
    {
        /// <summary>
        /// Assumption: Worksheet is in table format with no weird padding or blank column headers.
        /// 
        /// Assertion: Duplicate column names will be aliased by appending a sequence number (eg. Column, Column1, Column2)
        /// </summary>
        /// <param name="worksheet"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetWorksheetAsDataTable(Worksheet worksheet)
        {
            var dt = new System.Data.DataTable(worksheet.Name);
            ValueObjects.SheetName = worksheet.Name;
            dt.Columns.AddRange(GetDataColumns(worksheet).ToArray());
            var headerOffset = 1; //have to skip header row
            var width = dt.Columns.Count;
            var depth = GetTableDepth(worksheet, headerOffset);
            for (var i = 1; i <= depth; i++)
            {
                var row = dt.NewRow();
                for (var j = 1; j <= width; j++)
                {
                    var currentValue = worksheet.Cells[i + headerOffset, j].Value;

                    //have to decrement b/c excel is 1 based and datatable is 0 based.
                    row[j - 1] = currentValue == null ? null : currentValue.ToString();
                }

                dt.Rows.Add(row);
            }

            return dt;
        }

        /// <summary>
        /// Assumption: There are no null or empty cells in the first column
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="headerOffset"></param>
        /// <returns></returns>
        private static int GetTableDepth(Worksheet worksheet, int headerOffset)
        {
            var i = 1;
            var j = 1;
            var cellValue = worksheet.Cells[i + headerOffset, j].Value;
            while (cellValue != null)
            {
                i++;
                cellValue = worksheet.Cells[i + headerOffset, j].Value;
            }

            return i - 1; //subtract one because we're going from rownumber (1 based) to depth (0 based)
        }

        private static IEnumerable<DataColumn> GetDataColumns(Worksheet worksheet)
        {
            return GatherColumnNames(worksheet).Select(x => new DataColumn(x));
        }

        private static IEnumerable<string> GatherColumnNames(Worksheet worksheet)
        {
            var columns = new List<string>();

            var i = 1;
            var j = 1;
            var columnName = worksheet.Cells[i, j].Value;
            while (columnName != null)
            {
                columns.Add(GetUniqueColumnName(columns, columnName.ToString()));
                j++;
                columnName = worksheet.Cells[i, j].Value;
            }

            return columns;
        }

        private static string GetUniqueColumnName(IEnumerable<string> columnNames, string columnName)
        {
            var colName = columnName;
            var i = 1;
            while (columnNames.Contains(colName))
            {
                colName = columnName + i.ToString();
                i++;
            }

            return colName;
        }
    }
}
