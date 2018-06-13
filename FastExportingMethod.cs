using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sales_Commission
{
	static class FastExportingMethod
	{

		public static void ExportToExcel(DataSet dataSet, string tableName, List<int> datecolumns)
		{
            // Create the Excel Application object
            Application excelApp = new Application();

            // Create a new Excel Workbook
            Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
            try
            {

                int sheetIndex = 0;

                // Copy each DataTable
                foreach (System.Data.DataTable dt in dataSet.Tables)
                {

                    // Copy the DataTable to an object array
                    object[,] rawData = new object[dt.Rows.Count + 1, dt.Columns.Count];

                    // Copy the column names to the first row of the object array
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        rawData[0, col] = dt.Columns[col].ColumnName;
                    }

                    // Copy the values to the object array
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        for (int row = 0; row < dt.Rows.Count; row++)
                        {
                            rawData[row + 1, col] = dt.Rows[row].ItemArray[col];
                        }
                    }

                    // Calculate the final column letter
                    string finalColLetter = string.Empty;
                    string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    int colCharsetLen = colCharset.Length;

                    if (dt.Columns.Count > colCharsetLen)
                    {
                        finalColLetter = colCharset.Substring(
                            (dt.Columns.Count - 1) / colCharsetLen - 1, 1);
                    }

                    finalColLetter += colCharset.Substring(
                            (dt.Columns.Count - 1) % colCharsetLen, 1);

                    // Create a new Sheet
                    Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add(
                        excelWorkbook.Sheets.get_Item(++sheetIndex),
                        Type.Missing, 1, XlSheetType.xlWorksheet);

                    excelSheet.Name = tableName;

                    // Fast data export to Excel
                    string excelRange = string.Format("A1:{0}{1}",
                        finalColLetter, dt.Rows.Count + 1);

                    string excelColRange = string.Format("A1:{0}{1}",
                           finalColLetter, 1);

                    excelSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;
                    excelSheet.get_Range(excelColRange,Type.Missing).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(249, 161, 26));
                    excelSheet.get_Range(excelRange, Type.Missing).BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick, XlColorIndex.xlColorIndexNone, System.Drawing.Color.Black, Type.Missing);
                    Borders border = excelSheet.get_Range(excelColRange, Type.Missing).Borders;

                    border[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                    border[XlBordersIndex.xlEdgeLeft].Color = System.Drawing.Color.Black;
                    border[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                    border[XlBordersIndex.xlEdgeRight].Color = System.Drawing.Color.Black;
                    // Mark the first row as BOLD
                    ((Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;
                    ((Range)excelSheet.Rows[1, Type.Missing]).RowHeight = 57;
                    ((Range)excelSheet.Rows[1, Type.Missing]).ColumnWidth = 20;
                    //((Range)excelSheet.Rows[excelRange, Type.Missing]).BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexNone, System.Drawing.Color.Black, Type.Missing);
                    //((Range)excelSheet.Columns[excelColRange, Type.Missing]).BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexNone, System.Drawing.Color.Black, Type.Missing);


//                    ((Range)excelSheet.Columns[43, Type.Missing]).EntireColumn.NumberFormat = "dd/MM/yyyy";

                    datecolumns.ForEach(el => ((Range)excelSheet.Columns[el, Type.Missing]).EntireColumn.NumberFormat = "dd/MM/yyyy");
                }

                // Save and Close the Workbook
                //excelWorkbook.SaveAs(outputPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                //	Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                //	Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);


                //excelWorkbook.Close(true, Type.Missing, Type.Missing);

                // Release the Application object
                excelApp.Visible = true;
                excelApp.UserControl = true;
                //excelApp.Quit();
                excelApp = null;

                // Collect the unreferenced objects
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            catch(Exception ex)
            {

            }
            finally
            {
                excelWorkbook = null;
                excelApp = null;
            }

		}

        public static void ExportToExcel(DataSet dataSet, string tableName)
        {
            // Create the Excel Application object
            Application excelApp = new Application();

            // Create a new Excel Workbook
            Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
            try
            {

                int sheetIndex = 0;

                // Copy each DataTable
                foreach (System.Data.DataTable dt in dataSet.Tables)
                {

                    // Copy the DataTable to an object array
                    object[,] rawData = new object[dt.Rows.Count + 1, dt.Columns.Count];

                    // Copy the column names to the first row of the object array
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        rawData[0, col] = dt.Columns[col].ColumnName;
                    }

                    // Copy the values to the object array
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        for (int row = 0; row < dt.Rows.Count; row++)
                        {
                            rawData[row + 1, col] = dt.Rows[row].ItemArray[col];
                        }
                    }

                    // Calculate the final column letter
                    string finalColLetter = string.Empty;
                    string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    int colCharsetLen = colCharset.Length;

                    if (dt.Columns.Count > colCharsetLen)
                    {
                        finalColLetter = colCharset.Substring(
                            (dt.Columns.Count - 1) / colCharsetLen - 1, 1);
                    }

                    finalColLetter += colCharset.Substring(
                            (dt.Columns.Count - 1) % colCharsetLen, 1);

                    // Create a new Sheet
                    Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add(
                        excelWorkbook.Sheets.get_Item(++sheetIndex),
                        Type.Missing, 1, XlSheetType.xlWorksheet);

                    excelSheet.Name = tableName;

                    // Fast data export to Excel
                    string excelRange = string.Format("A1:{0}{1}",
                        finalColLetter, dt.Rows.Count + 1);

                    string excelColRange = string.Format("A1:{0}{1}",
                           finalColLetter, 1);

                    excelSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;
                    excelSheet.get_Range(excelColRange, Type.Missing).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(249, 161, 26));
                    excelSheet.get_Range(excelRange, Type.Missing).BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick, XlColorIndex.xlColorIndexNone, System.Drawing.Color.Black, Type.Missing);
                    Borders border = excelSheet.get_Range(excelColRange, Type.Missing).Borders;

                    border[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                    border[XlBordersIndex.xlEdgeLeft].Color = System.Drawing.Color.Black;
                    border[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                    border[XlBordersIndex.xlEdgeRight].Color = System.Drawing.Color.Black;
                    // Mark the first row as BOLD
                    ((Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;
                    ((Range)excelSheet.Rows[1, Type.Missing]).RowHeight = 57;
                    ((Range)excelSheet.Rows[1, Type.Missing]).ColumnWidth = 20;


                }

                // Save and Close the Workbook
                //excelWorkbook.SaveAs(outputPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                //	Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                //	Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);



                // Release the Application object
                excelApp.Visible = true;
                excelApp.UserControl = true;
                //excelApp.Quit();
                excelApp = null;

                // Collect the unreferenced objects
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            catch (Exception ex)
            {

            }
            finally
            {
                excelWorkbook = null;
                excelApp = null;
            }

        }

    }
}
