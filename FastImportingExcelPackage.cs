using ClosedXML.Excel;
using System;
using System.Data;

namespace Sales_Commission
{
    static class FastImportingExcelPackage
    {
        public static DataTable ImportSheet(string fileName)
        {
            try
            {
                var datatable = new DataTable();
                var workbook = new XLWorkbook(fileName);
                string sheetname = null;
                IXLRange range = null;
                foreach (IXLWorksheet worksheet in workbook.Worksheets)
                {
                    if (worksheet.Name.ToLower().Contains("upload"))
                    {
                        range = worksheet.Range(worksheet.FirstCellUsed(), worksheet.LastCellUsed());
                        sheetname = worksheet.Name;
                    }
                    else if (worksheet.Name.ToLower().Contains("flexibleupload"))
                    {
                        range = worksheet.Range(worksheet.FirstCellUsed(), worksheet.LastCellUsed());
                        sheetname = worksheet.Name;
                    }
                }
                if (!string.IsNullOrEmpty(sheetname))
                {
                    GetSheetValues(datatable, workbook, sheetname, range);
                }
                return datatable;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void GetSheetValues(DataTable datatable, XLWorkbook workbook, string sheetname, IXLRange range)
        {
            var xlWorksheet = workbook.Worksheet(sheetname);

            var col = range.ColumnCount();
            var row = range.RowCount();

            //if a datatable already exists, clear the existing table 
            datatable.Clear();
            for (var i = 1; i <= col; i++)
            {
                var column = xlWorksheet.Cell(1, i);
                datatable.Columns.Add(column.Value.ToString());
            }

            var firstHeadRow = 0;
            foreach (var item in range.Rows())
            {
                if (firstHeadRow != 0)
                {
                    var array = new object[col];
                    for (var y = 1; y <= col; y++)
                    {
                        array[y - 1] = item.Cell(y).Value;
                    }

                    datatable.Rows.Add(array);
                }
                firstHeadRow++;
            }
        }
    }
}
