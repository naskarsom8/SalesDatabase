using System;
using System.Data.SqlClient;
using System.Data;

namespace Sales_Commission
{
    public abstract class Abstract_CRUD_Methods
    {
        public abstract DataTable execSelectQuery(string _query, SqlParameter[] SQLparams);

        public virtual void execSelectQuery(string _query, DataTable dtb)
        {

        }

        public virtual void execSelectQuery(string _query, DataTable dtb, SqlParameter[] SQLparams)
        {

        }

        public virtual DataTable execSelectQuery(string _query, params string[] param)
        {
            DataTable dtb = new DataTable();

            return dtb;
        }

        public virtual DataTable execSelectQuery(string _query)
        {
            DataTable dtb = new DataTable();

            return dtb;
        }

        public abstract bool execQuery(string _query);

        public abstract bool execInsertQuery(string _query, DataTable dt);

        public abstract bool execInsertQuery(string _query, SqlParameter[] SQLparams);

        //public abstract bool execUpdateQuery(string _query, DataTable dt);

    }
}
