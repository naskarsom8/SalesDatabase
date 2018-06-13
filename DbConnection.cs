using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sales_Commission
{
    class DbConnection : Abstract_CRUD_Methods
    {
        private static SqlDataAdapter adapter;
        private static SqlConnection conn;
        
        /// <summary>
        /// DbConnection constructor initializes the members.
        /// </summary>
        static DbConnection()
        {
            adapter = new SqlDataAdapter();
            conn = new SqlConnection(Properties.Settings.Default.Connection_String.ToString());
            ValueObjects.Msgboxheader = "Error";
        }

        /// <summary>
        /// openconnection: This function opens the connection to Gesi Sales database.
        /// </summary>
        /// <returns></returns>
        private SqlConnection openconnection()
        {
            ValueObjects.ReturnValue = false;
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    try
                    {
                        conn.Open();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You are referencing an invalid server" + "\n" +
                            "Kindly check if you have access to the following" + "\n"
                            + "server: sqs031.ad.esi.adp.com\\MSSFEGESIS01,1435" + "\n"
                            + "database:" + conn.Database.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
            return conn;
        }

        /// <summary>
        /// execSelectQuery with SQLParameter array as one of the parameters.
        /// </summary>
        /// <param name="_query"></param>
        /// <param name="SQLparams"></param>
        /// <returns>Data Table</returns>
        public override DataTable execSelectQuery(string _query, SqlParameter[] SQLparams)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openconnection();
                cmd.CommandText = _query;
                if(_query.Contains("_sp"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(SQLparams);
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
                else 
                {
                    adapter.SelectCommand = cmd;
                    cmd.Parameters.AddRange(SQLparams);
                    cmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    dt = ds.Tables[0];
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error in Connection.execSelectQuery with parameters - Query:" + "\n" + _query + "\n\n" + e.Message 
                    , ValueObjects.Msgboxheader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input.", "Select Query Error With Parameters.");

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        /// <summary>
        /// execSelectQuery with datatable as one of the parameter.
        /// </summary>
        /// <param name="_query"></param>
        /// <param name="dtb"></param>
        /// <returns> Data Table</returns>
        public override void execSelectQuery(string _query, DataTable dtb)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openconnection();
                cmd.CommandText = _query;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dt", dtb);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error in Connection.execSelectQuery with Data Table - Query:" + "\n" + _query + "Exception: " +
                    e.Message, ValueObjects.Msgboxheader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Query With Data Table Error","Invalid input");

            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// execSelectQuery takes three string parameters. The first parameter should be the SQL query.
        /// </summary>
        /// <param name="_query"></param>
        /// <param name="Script"></param>
        /// <param name="Type"></param>
        /// <returns> Data Table</returns>
        public override DataTable execSelectQuery(string _query, params string[] param)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openconnection();
                cmd.CommandText = _query;
                cmd.CommandType = CommandType.StoredProcedure;

                //if((param[3].ToString() == "Streamline" || param[3].ToString() == "Global View" || param[3].ToString() == "Date_Processed" || param[3].ToString() == "RollCall_Date") && param[2].ToString() != "Commission")
                //{
                //    cmd.Parameters.AddWithValue("@FromDate", param[0].ToString());
                //    cmd.Parameters.AddWithValue("@ToDate", param[1].ToString());
                //    cmd.Parameters.AddWithValue("@BU_Name", param[2].ToString());
                //    cmd.Parameters.AddWithValue("@Type", param[4].ToString());
                //}

                //This if statement runs the extract for Streamline and BOB countries
                if(!(param[3].ToString() == "EOD" /*|| param[3].ToString() == "Streamline" || param[3].ToString() == "Global View"*/) && param[2].ToString() != "Commission")
                {
                    cmd.Parameters.AddWithValue("@FromDate", param[0].ToString());
                    cmd.Parameters.AddWithValue("@ToDate", param[1].ToString());
                    cmd.Parameters.AddWithValue("@BU_Name", param[2].ToString());
                    cmd.Parameters.AddWithValue("@CountryName", param[3].ToString());
                    cmd.Parameters.AddWithValue("@Type", param[4].ToString());
                }
                //This if statement runs the extract for EOD Implementation.
                else if ((param[3] == "EOD" || param[3] == "United Kingdom") && param[2].ToString()!="Commission")
                {
                    cmd.Parameters.AddWithValue("@FromDate", param[0].ToString());
                    cmd.Parameters.AddWithValue("@ToDate", param[1].ToString());
                    cmd.Parameters.AddWithValue("@BU_Name", param[2].ToString());
                    cmd.Parameters.AddWithValue("@Type", param[4].ToString());
                }
                //This if statement runs the extract for commission.
                else
                {
                    cmd.Parameters.AddWithValue("@FromDate", param[0].ToString());
                    cmd.Parameters.AddWithValue("@ToDate", param[1].ToString());
                    cmd.Parameters.AddWithValue("@BU_Name", param[2].ToString());
                    cmd.Parameters.AddWithValue("@CountryName", param[3].ToString());
                }
                dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error in Connection.execSelectQuery with Data Table - Query:" + "\n" + ex.Message + "Exception: " +
                    "Data did not load. Please try again.", ValueObjects.Msgboxheader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input", "Select Query With Data Table Error");

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        /// <summary>
        /// execSelectQuery without parameter.
        /// </summary>
        /// <param name="_query"></param>
        /// <returns>Data Table</returns>
        public override DataTable execSelectQuery(string _query)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            dt = null;
            DataSet ds = new DataSet();

            try
            {
                cmd.Connection = openconnection();
                cmd.CommandText = _query;
                adapter.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                adapter.Fill(ds);
                dt = ds.Tables[0];

            }
            catch (SqlException e)
            {
                MessageBox.Show("Exception Raised: \n\n" + e.Message, ValueObjects.Msgboxheader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Raised: \n\n" + ex.Message, "Select Query With Params.",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        /// <summary>
        /// Method that executes the back stored procedure.
        /// </summary>
        /// <param name="_query"></param>
        public override bool execQuery(string _query)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = openconnection();
                cmd.CommandText = _query;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                ValueObjects.ReturnValue = true;
            }

            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Exception");
            }
            catch(Exception ex)
            {
                MessageBox.Show("The application did not run due to an unresolved issue. Please resolve the error and proceed.","Main Exeption");
            }
            finally
            {
                conn.Close();
            }
            return ValueObjects.ReturnValue;
        }

        /// <summary>
        /// Method runs the Storded Procedure that inserts data from user datatable to the database.
        /// </summary>
        /// <param name="_query"></param>
        /// <param name="dt"></param>
        public override bool execInsertQuery(string _query, DataTable dt)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = openconnection();
                cmd.CommandText = _query;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dt",dt);
                cmd.ExecuteNonQuery();
                ValueObjects.ReturnValue = false;
            }
            catch(SqlException ex)
            {
                MessageBox.Show( ex.Message + "\n Please resolve the error and proceed.", "SQL Exception");
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message + "\n Please contact your system administrator.", "Main Exeption");
            }
            finally
            {
                conn.Close();
            }
            return ValueObjects.ReturnValue;
        }

        public override bool execInsertQuery(string _query, SqlParameter[] SQLparams)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = openconnection();
                cmd.CommandText = _query;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddRange(SQLparams);
                cmd.ExecuteNonQuery();
                ValueObjects.ReturnValue = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\n Please resolve the error and proceed.", "SQL Exception");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Please contact your system administrator.", "Main Exeption");
            }
            finally
            {
                conn.Close();
            }

            return ValueObjects.ReturnValue;
        }

        /// <summary>
        /// Copies the columns of the Datagridview to the repective table based on column mappings. The Columns should exactly match the database columns.
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="DestinationTbl"></param>
        /// <param name="batchsize"></param>
        public bool BulkCopyInsert(DataTable dt, string DestinationTbl, int batchsize)
        {
            SqlBulkCopy sbc = new SqlBulkCopy(openconnection());
            sbc.DestinationTableName = DestinationTbl;
            sbc.BatchSize = batchsize;
            //Extension method to convert
            dt = ValueObjects.FormatDateColumn(dt);

            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName == "CUID")
                {
                    sbc.ColumnMappings.Add(new SqlBulkCopyColumnMapping("CUID", "Payroll No"));
                }
                else
                {
                    sbc.ColumnMappings.Add(new SqlBulkCopyColumnMapping(col.ColumnName, col.ColumnName));
                }

            }

            ////Test Code:

            //for (int i = 0; i < 19; i++)
            //{
            //    if (dt.Columns[i].ColumnName == "CUID")
            //    {
            //        sbc.ColumnMappings.Add(new SqlBulkCopyColumnMapping("CUID", "Payroll No"));
            //    }
            //    else
            //    {
            //        sbc.ColumnMappings.Add(new SqlBulkCopyColumnMapping(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName));
            //    }
            //}

            try
            {
                sbc.WriteToServer(dt);
                ValueObjects.ReturnValue = true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return ValueObjects.ReturnValue;
        }

    }
}
