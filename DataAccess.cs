using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sales_Commission
{
    class DataAccess : TableColumns
    {
        private DbConnection conn;

        DataRow dr;
        DataTable dt = new DataTable();
        bool rtnvalue;

        /// <Constructor>
        /// DataAccess Class Constructor
        /// </Constructor>
        public DataAccess()
        {
            conn = new DbConnection();
            
        }

        #region [Select Query Method(s)]

        /// <summary>
        /// Returns the appropriate Adjustment data based on the Adjustment Type selection.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="columns"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        internal DataTable GetAdjustmentDetails(int index, string country, string from, string to)
        {
            string _query = null;
            switch (index)
            {
                case 1:
                    _query = string.Format("[Sales].[AuditFlexibleUpload_sp]");
                    break;
                case 2:
                    _query = string.Format("[Sales].[NoStartFlexibleUpload_sp]");
                    break;
                case 3:
                    _query = string.Format("[Sales].[OtherFlexibleUpload_sp]");
                    break;
                default:
                    break;
            }

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Country", SqlDbType.NVarChar, 100);
            param[0].Value = country;

            param[1] = new SqlParameter("@StartDate", SqlDbType.VarChar, 10);
            param[1].Value = from;

            param[2] = new SqlParameter("@EndDate", SqlDbType.VarChar, 10);
            param[2].Value = to;
            return conn.execSelectQuery(_query, param);
        }

        /// <summary>
        /// This function uploads the data in the respective country Upload table in Sales db.
        /// </summary>
        /// <param name="Country"></param>
        /// <param name="Table"></param>
        /// <returns></returns>
        internal bool GetUploadDetails(string Country, DataTable Table)            
        {
            string _query = null;
            int Sp_country = 0;

            switch (Country)
            {
                case "united kingdom":
                    _query = string.Format("[Sales].[Upload_SP]");
                    Sp_country = 1;
                    break;
                case "streamline":
                    _query = string.Format("[Sales].[Upload_SL_sp]");
                    Sp_country = 2;
                    break;
                case "global view":
                    _query = string.Format("[Sales].[Upload_GV_sp]");
                    Sp_country = 3;
                    break;
                case "Netherlands":
                    break;
                case "Spain and Portugal":
                    break;
                case "Italy":
                    break;
                case "Poland":
                    break;
                case "Switzerland":
                default:
                    break;
            }
            
            conn.execSelectQuery(_query, Table);
            if (Sp_country > 0)
            {
                if (ExecuteProcedure(Sp_country) != true)
                {
                    MessageBox.Show("The Data wasn't loaded successful", "Load Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return true;
        }

        internal bool ExecuteProcedure(int Country)
        {
            string _query = null;
            rtnvalue = false;
            switch (Country)
            {
                case 1:
                    _query = string.Format("[Sales].[SalesOrder_BOB_sp]");
                    break;
                case 2:
                    _query = string.Format("[Sales].[SalesOrder_SL_sp]");
                    break;
                case 3:
                    _query = string.Format("[Sales].[SalesOrder_GV_sp]");
                    break;
                case 4:
                    _query = string.Format("[Sales].[Order_Deletion_sp]");
                    break;
                default:
                    break;
            }

            if (conn.execQuery(_query) == true)
            {
                rtnvalue = true;
            }
            return rtnvalue;
        }

        /// <summary>
        /// Gets all the business unit names currently available in the database.
        /// </summary>
        /// <returns></returns>
        internal List<string> GetBUNames(string formName)
        {
            string _query = string.Format("select distinct case when BU_Name like 'Best Of Breed%' Then Country_Name else BU_Name end as Country_Name"+
                " FROM [GESI_SalesDatabase].[Sales].[vw_OrderData_Total] order by 1");
            List<string> BUNames = new List<string>();

            DataTable dt =  conn.execSelectQuery(_query);
            BUNames.Add("");

            if(formName == "Flexible_Upload")
            {
                BUNames.Add("2SP");
            }

            foreach(DataRow row in dt.Rows)
            {
                BUNames.Add(row["Country_Name"].ToString());
            }

            if (formName == "Flexible_Upload")
            {
                BUNames.Add("United Kingdom - CPQ");
            }
            return BUNames;
        }

        /// <summary>
        /// This function gets the various extracts data from db.
        /// </summary>
        /// <param name="extract"></param>
        /// <param name="frm"></param>
        /// <param name="to"></param>
        /// <returns>Data Table</returns>
        internal DataTable GetExtracts(int extract, string country, string frm, string to, string type, string BUName)
        {
            // need to initialize the variables before using in the Switch.
            string _query = null;
            
            switch (extract)
            {
                case 1:
                    type = type == "Date_Processed" ? "Processed_Date" : "RollCall_Date";
                    switch(country)
                    {
                        case "Streamline":
                            _query = string.Format("[Sales].[Extract_Combined_sp]");
                            break;
                        case "Global View":
                            _query = string.Format("[Sales].[Extract_Combined_sp]");
                            break;
                        default:
                            _query = string.Format("[Sales].[Extract_Combined_sp]");
                            break;
                    }
                    break;
                case 2:
                    _query = string.Format("[Sales].[Commissions_sp]");
                    BUName = "Commission";
                    break;
                case 3:
                    _query = string.Format("[Sales].[Extract_Deleted_MNC_sp]");
                    break;
                case 4:
                    _query = string.Format("[Sales].[EOD_Report_sp]");
                    type = country == "Date Processed" ? "Processed_Date" : "RollCall_Date";
                    country = "EOD";
                    BUName = "Best Of Breed";
                    break;
                default:
                    MessageBox.Show("Please select an extract type before proceeding.","Invalid Input.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    break;
            }

                return conn.execSelectQuery(_query, frm, to, BUName, country, type);
        }

        /// <summary>
        /// This function gets the view of data that is being deleted.
        /// </summary>
        /// <param name="BUName"></param>
        /// <param name="frm"></param>
        /// <param name="to"></param>
        /// <param name="So_Number"></param>
        /// <returns></returns>
        internal DataTable GetDeleteDetails(string BUName, string frm, string to, string So_Number, string dttype)
        {
            string _query = null;
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@So_Number", SqlDbType.NVarChar,int.MaxValue);
            param[1] = new SqlParameter("@from", SqlDbType.NVarChar, 50);
            param[2] = new SqlParameter("@to", SqlDbType.NVarChar, 50);
            param[3] = new SqlParameter("@dttype", SqlDbType.NVarChar, 50);
            param[4] = new SqlParameter("@BUName", SqlDbType.NVarChar,255);
            

            param[1].Value = frm;
            param[2].Value = to;
            param[3].Value = dttype;

            switch (BUName)
            {
                case "Streamline":
                    param[4].Value = BUName;
                    break;
                case "Global View":
                    param[4].Value = BUName;
                    break;
                case "Italy":
                    param[4].Value = BUName;
                    break;
                case "Spain":
                    param[4].Value = BUName;
                    break;
                case "Poland":
                    param[4].Value = BUName;
                    break;
                case "Switzerland":
                    param[4].Value = BUName;
                    break;
                case "":
                    break;
                default:
                    param[4].Value = BUName;
                    break;
            }

            if (string.IsNullOrEmpty(So_Number) || string.IsNullOrWhiteSpace(So_Number) || So_Number.Contains("Enter"))
            {
                param[0].Value = DBNull.Value;
                switch(BUName)
                {
                    case "Streamline":
                    case "Global View":
                        _query = string.Format("Select * from [Sales].[vw_Extract_BOB] where " + dttype + " between @from and @to and [BU_Name] = @BUName");
                        break;
                    default:
                        _query = string.Format("Select * from [Sales].[vw_Extract_BOB] where " + dttype + " between @from and @to and [Selling_Country] = @BUName");
                        break;
                }
            }
            else
            {
                param[0].Value = So_Number;
                switch (BUName)
                {
                    case "Streamline":
                    case "Global View":
                        _query = string.Format("Select * from [Sales].[vw_Extract_BOB] where SO_Number in (select SO_Number from [GESI_SalesDatabase].[dbo].[Deal_delete]) and [BU_Name] = @BUName");
                        break;
                    default:
                        _query = string.Format("Select * from [Sales].[vw_Extract_BOB] where SO_Number in (select SO_Number from [GESI_SalesDatabase].[dbo].[Deal_delete]) and [Selling_Country] = @BUName");
                        break;
                }
            }

            return conn.execSelectQuery(_query, param);
        }

        /// <summary>
        /// This function gets the country codes with their names
        /// separated by "-"
        /// </summary>
        /// <returns></returns>
        internal List<string> GetCountries()
        {
            List<string> CountryLst = new List<string>();
            string _query = string.Format("Select [Country_Code],[Country_Name] from [GESI_SalesDatabase].[Reference].[vw_Countries]");

            foreach(DataRow row in conn.execSelectQuery(_query).Rows)
            {
                CountryLst.Add(row["Country_Code"].ToString()+ "-" + row["Country_Name"].ToString());
            }

            return CountryLst;
        }

        /// <summary>
        /// Gets the column name of a particular SQL table.
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        internal List<string> GetColumnNames(string TableName)
        {
            List<string> cols = new List<string>();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@tableName", SqlDbType.NVarChar, 100);
            param[0].Value = TableName;

            string _query = string.Format("Select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = @tableName");

            try
            {
                foreach(DataRow row in conn.execSelectQuery(_query,param).Rows)
                {
                    cols.Add(row["COLUMN_NAME"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Adjustment columns.");
            }

            return cols;
        }

        /// <summary>
        /// Gets the Hierarchy and its table infromation based on the table name.
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="BUId"></param>
        /// <returns></returns>
        internal List<string> GetHierarchyDetails(string TableName, int BUId)
        {
            List<string> values = new List<string>();
            values.Add("");
            string _query;
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@active", SqlDbType.Int);
            param[1] = new SqlParameter("@BUid", SqlDbType.Int);
            param[2] = new SqlParameter("@teams",SqlDbType.NVarChar,255);
            param[3] = new SqlParameter("@ReportingToName", SqlDbType.NVarChar, 255);


            param[0].Value = 1;
            param[1].Value = (BUId <= 0) ? 1 : BUId;
            param[2].Value = string.IsNullOrEmpty(ValueObjects.TeamName) ? "null" : ValueObjects.TeamName;
            param[3].Value = string.IsNullOrEmpty(ValueObjects.ReportingTo) ? "null" : ValueObjects.ReportingTo;


            switch (TableName)
            {
                case "designations":
                    _query = string.Format("SELECT CONCAT([Designation_Id],' - ',[Designation_Code],' (',[Designation_Type],')') FROM [GESI_SalesDatabase].[Reference].[Designations] where ActiveDesignation = @active order by 1");
                    break;

                case "segments":
                    _query = string.Format("SELECT Concat([Segment_Id], ' - ', [SegmentName]) as Segments FROM [GESI_SalesDatabase].[Reference].[Segment] where ActiveSegment = @active");
                    break;

                case "salesteamid":
                    _query = string.Format("SELECT [SalesTeam_Id] FROM [GESI_SalesDatabase].[Reference].[Sales_Teams] where SalesTeam_Id = (select max(SalesTeam_Id) from [GESI_SalesDatabase].[Reference].[Sales_Teams])");
                    break;

                case "segmentid":
                    _query = string.Format("SELECT [Segment_Id] as Segments FROM [GESI_SalesDatabase].[Reference].[Segment] where Segment_Id = (select max(Segment_Id) from [GESI_SalesDatabase].[Reference].[Segment])");
                    break;

                case "designationid":
                    _query = string.Format("SELECT [Designation_Id] FROM [GESI_SalesDatabase].[Reference].[Designations] where Designation_Id = (select max(Designation_Id) from [GESI_SalesDatabase].[Reference].[Designations] where Designation_Id != 999)");
                    break;

                case "teamid":
                    _query = string.Format("SELECT [SalesTeam_Id] FROM [GESI_SalesDatabase].[Reference].[Sales_Teams] where [SalesTeam_Name] = @teams");
                    break;

                case "reportingtoid":
                    _query = string.Format("select Person_Id FROM [GESI_SalesDatabase].[Reference].[SalesPerson] where Name = @ReportingToName");
                    break;

                case "reportingto":
                    _query = string.Format("select distinct Name FROM [GESI_SalesDatabase].[Reference].[SalesPerson] where Designation_Id not in (1,4,8) and BUID = @BUid");
                    param[1].Value = BUId;
                    break;

                case "segmentteam":
                    _query = string.Format("SELECT concat(st.SalesTeam_Name, '~', s.Segment_Id,' - ' ,s.SegmentName) as TS FROM [GESI_SalesDatabase].[Reference].[SalesPerson] sp"
                              + " left join[Reference].[Sales_Teams] st"
                              +" on sp.SalesTeam_Id = st.SalesTeam_Id"
                              +" left join[Reference].[Segment] s"
                              +" on sp.Segment_Id = s.Segment_Id"
                              +" where Latest = 1 and Person_Id =" + "'" + ValueObjects.PersonId + "'");
                    break;

                default:
                    _query = string.Format("SELECT [SalesTeam_Name] FROM [GESI_SalesDatabase].[Reference].[Sales_Teams] where ActiveTeam = @active and BUID = @BUid");
                    param[1].Value = BUId;
                    break;
            }

            try
            {
                foreach(DataRow row in conn.execSelectQuery(_query, param).Rows)
                {
                    values.Add(row[0].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return values;
        }

        #endregion

        #region [Insert Method(s)]

        /// <summary>
        /// InsertChangeHistory Method to insert the Audit trail information in the db.
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="param"></param>
        internal bool InsertChangeHistory(string tablename, params string[] param)
        {
            dt.Reset();
            dt.TableName = tablename;
            rtnvalue = false;
            string _query = string.Format("[Reference].[ChangeHistoryUpload_sp]");

            dt = ChangeHistoryCols(dt);
            dr = dt.NewRow();

            for (int i = 0; i < param.Length; i++)
            {
                dr[i] = param[i].ToString();
            }

            dt.Rows.Add(dr);

            if(conn.execInsertQuery(_query, dt) == true);
            {
                rtnvalue = true;
            }

            return rtnvalue;
        }

        /// <summary>
        /// THis function inserts the order number in the Order deletion table
        /// before actually deleting it from Sales Order table.
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="values"></param>
        /// <param name="param"></param>
        internal bool InsertOrderDeletion(string tablename, List<string> values, params string[] param)
        {
            dt.Reset();
            dt.TableName = tablename;
            rtnvalue = false;
            string _query = string.Format("[Sales].[Order_DeletionUpload_sp]");

            dt = OrderDeletionCols(dt);

            if(values.Count == 0)
            {
                values.Add("Enter");
            }

            for (int i = 0; i < values.Count; i++)
            {
                dr = dt.NewRow();
                if (values[0].ToString() == "Enter") 
                {
                    dr[0] = DBNull.Value;
                }
                else
                {
                    dr[0] = values[i].ToString();
                }

                for (int a = 0; a < param.Length; a++)
                {
                    if (string.IsNullOrEmpty(param[a].ToString()) || string.IsNullOrWhiteSpace(param[a].ToString()))
                    {
                        dr[a + 1] = DBNull.Value;
                    }
                    else
                    {
                        dr[a + 1] = param[a].ToString();
                    }
                }
                dt.Rows.Add(dr);
            }


            if(conn.execInsertQuery(_query, dt)==true)
            {
                rtnvalue = true;
            }
            return rtnvalue;
        }

        /// <summary>
        /// This function loads the flexible upload data in the database and updates the various order tables.
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="DestTableName"></param>
        /// <param name="batchsize"></param>

        internal bool InsertFlexibleUpload(DataTable dt, string DestTableName, int batchsize)
        {
            rtnvalue = false;
            if (conn.BulkCopyInsert(dt, DestTableName, batchsize) == true && conn.execQuery(string.Format("[Sales].[flexibleUploadUpdate_sp]")) == true)
            {
                rtnvalue = true;
            }
            return rtnvalue;
        }

        /// <summary>
        /// This function loads the Orders Upload data in teh database based on country selected.
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="DestTableName"></param>
        /// <param name="batchsize"></param>
        internal bool InsertOrdersUpload(DataTable dt, string DestTableName, int batchsize)
        {

            rtnvalue = conn.BulkCopyInsert(dt, DestTableName, batchsize) == true ? true : false;

            if(rtnvalue == true)
            {
                switch (DestTableName)
                {
                    case "dbo.SL":
                        rtnvalue = conn.execQuery(string.Format("[Sales].[SalesOrder_SL_sp]")) == true ? true : false;
                        break;
                    case "dbo.MNC":
                        rtnvalue = conn.execQuery(string.Format("[Sales].[SalesOrder_GV_sp]")) == true ? true : false;
                        break;
                    case "dbo.UK_Upload":
                        rtnvalue = conn.execQuery(string.Format("[Sales].[SalesOrder_UKCPQ_sp]")) == true ? true : false;
                        break;
                    case "dbo.SP":
                        rtnvalue = conn.execQuery(string.Format("[Sales].[SalesOrder_2SPI_sp]")) == true ? true : false;
                        break;
                    default:
                        rtnvalue = false;
                        break;
                }
            }
            return rtnvalue;
            
        }

        internal bool InsertHierarchyDetails(string DestTablName, int Id, string value1, string value2, int value3)
        {
            string _query = null;

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Id",SqlDbType.Int);
            param[0].Value = Id;

            param[1] = new SqlParameter("@value1", SqlDbType.NVarChar,255);
            param[1].Value = value1;

            param[2] = new SqlParameter("@value2", SqlDbType.NVarChar,255);
            param[2].Value = value2;

            param[3] = new SqlParameter("@value3",SqlDbType.Int);
            param[3].Value = value3;


            switch (DestTablName)
            {
                case "designations":
                    _query = string.Format("insert into [GESI_SalesDatabase].[Reference].[Designations] ([Designation_Id], [Designation_Code], [Designation_Type], [ActiveDesignation]) values (@Id, @value1, @value2,@value3)");
                    break;
                case "segments":
                    _query = string.Format("INSERT INTO [GESI_SalesDatabase].[Reference].[Segment] ([Segment_Id], [SegmentName], [ActiveSegment], [Other_Seg_Mapping]) VALUES (@Id, @value1, @value2,@value3)");
                    break;
                default:
                    _query = string.Format("INSERT INTO [GESI_SalesDatabase].[Reference].[Sales_Teams] ([SalesTeam_Id], [SalesTeam_Name], [ActiveTeam], [BUID]) VALUES (@Id, @value1, @value2,@value3)");
                    break;
            }

            rtnvalue = conn.execInsertQuery(_query, param) == true ? true : false;

            return rtnvalue;
        }


        internal bool InsertSalesPersonDetails(int id, string name, int roleid, int reportingto, int salesteamid, int segmentid, int buid, string stdate, bool latest)
        {
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@id",SqlDbType.Int);
            param[1] = new SqlParameter("@name",SqlDbType.NVarChar,255);
            param[2] = new SqlParameter("@roleid",SqlDbType.Int);
            param[3] = new SqlParameter("@reportingto",SqlDbType.Int);
            param[4] = new SqlParameter("@salesteamid",SqlDbType.Int);
            param[5] = new SqlParameter("@segmentid",SqlDbType.Int);
            param[6] = new SqlParameter("@modifieddate", SqlDbType.NVarChar, 23);
            param[7] = new SqlParameter("@buid",SqlDbType.Int);
            param[8] = new SqlParameter("@stdate",SqlDbType.NVarChar,23);
            param[9] = new SqlParameter("@status", SqlDbType.Bit);
            param[10] = new SqlParameter("@latest", SqlDbType.Bit);

            param[0].Value = id;
            param[1].Value = name;
            param[2].Value = roleid;
            param[3].Value = reportingto;
            param[4].Value = salesteamid;
            param[5].Value = segmentid;
            param[6].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff");
            param[7].Value = buid;
            param[8].Value = stdate;
            param[9].Value = 1;
            param[10].Value = latest == true ? 1 : 0;

            string _query = string.Format("INSERT INTO [Reference].[SalesPerson] ([Person_Id], [Name], [Designation_Id], [Reporting_To], [SalesTeam_Id], [Segment_Id], [Modified_Date], [BUID]"
                + ", [Start_Date], [Status], [Latest]) values (@id, @name, @roleid, @reportingto, @salesteamid, @segmentid, @modifieddate, @buid, @stdate, @status, @latest)");

            rtnvalue = conn.execInsertQuery(_query,param) == true ? true : false;
            return rtnvalue;
        }
        #endregion

    }
}