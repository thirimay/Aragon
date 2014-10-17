using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Hellespont_DPO_JobSite.Model
{
    public class DBConnection
    {
        public DBConnection()
        {           

        }

        #region Connection
        public SqlConnection SqlCon()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            return con;
        }
        #endregion
        #region Command
        public SqlCommand SqlCom(string cmd)
        {
            SqlConnection con = SqlCon();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = cmd;
            return com;
        }
        #endregion

        #region executecommand
        public bool executecommand(SqlCommand comd)
        {
            bool result = false;
            SqlConnection con = SqlCon();
            comd.Connection = con;
            try
            {
                comd.Connection.Open();
                comd.ExecuteNonQuery();
                result = true;
            }
            /*  catch (Exception)
              {
                  result = false;
              }*/
            finally
            {
                comd.Connection.Close();
            }
            return result;
        }
        #endregion


        #region Datatable
        public DataTable DataTB(SqlCommand com)
        {
            SqlDataAdapter adapt = new SqlDataAdapter(com);
            DataTable datatb = new DataTable();
            adapt.Fill(datatb);
            return datatb;
        }
        #endregion


    }
}