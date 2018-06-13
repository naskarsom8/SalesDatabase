using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sales_Commission
{
    static class SQLDynamicTypeCreator
    {
        internal static string CreateTypeScript(DataTable Table)
        {
            //if (!Helper.IsValidDatatable(Table, IgnoreZeroRows: true))
            //    return string.Empty;

            StringBuilder result = new StringBuilder();
            result.AppendFormat("CREATE TYPE Sales.{1} as Table ({0}   ", Environment.NewLine, "FlexibleUploadDt");

            bool FirstTime = true;
            foreach (DataColumn column in Table.Columns.OfType<DataColumn>())
            {
                if (FirstTime) FirstTime = false;
                else
                    result.Append(",");

                result.AppendFormat("[{0}] {1} {2}",
                    column.ColumnName, // 0
                    GetSQLTypeAsString(column.DataType), // 1
                    column.AllowDBNull ? "NULL" : "NOT NULL"//, // 2
                    //Environment.NewLine // 3
                );
            }
            result.AppendFormat(") {0}", Environment.NewLine);

            //// Build an ALTER TABLE script that adds keys to a table that already exists.
            //if (Table.PrimaryKey.Length > 0)
            //    result.Append(BuildKeysScript(Table));

            return result.ToString();
            //string result = null;
            //return result;
        }

        internal static string TextSeparator(string Values)
        {
            //if (!Helper.IsValidDatatable(Table, IgnoreZeroRows: true))
            //    return string.Empty;
            string[] mValues = Values.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            bool FirstTime = true;
            foreach (string s in mValues)
            {
                if (FirstTime) FirstTime = false;
                else
                    result.Append(",");

                result.AppendFormat("{0}",s);
            }
            //result.AppendFormat("{0}", Environment.NewLine);

            //// Build an ALTER TABLE script that adds keys to a table that already exists.
            //if (Table.PrimaryKey.Length > 0)
            //    result.Append(BuildKeysScript(Table));

            return result.ToString();
            //string result = null;
            //return result;
        }

        /// <summary>
        /// Returns the SQL data type equivalent, as a string for use in SQL script generation methods.
        /// </summary>
        private static string GetSQLTypeAsString(Type DataType)
        {
            switch (DataType.Name)
            {
                case "Boolean": return "[bit]";
                case "Char": return "[char]";
                case "SByte": return "[tinyint]";
                case "Int16": return "[smallint]";
                case "Int32": return "[int]";
                case "Int64": return "[bigint]";
                case "Byte": return "[tinyint] UNSIGNED";
                case "UInt16": return "[smallint] UNSIGNED";
                case "UInt32": return "[int] UNSIGNED";
                case "UInt64": return "[bigint] UNSIGNED";
                case "Single": return "[float]";
                case "Double": return "[double]";
                case "Decimal": return "[decimal]";
                case "DateTime": return "[datetime]";
                case "Guid": return "[uniqueidentifier]";
                case "Object": return "[variant]";
                case "String": return "[nvarchar] (250)";
                default: return "[nvarchar] (MAX)";
            }
        }
    }
}
