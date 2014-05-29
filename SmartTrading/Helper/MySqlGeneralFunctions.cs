using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;
using System.Windows.Forms;
namespace SmartTrading.Helper
{
    public class MySqlGeneralFunction
    {
        public static int ExecuteNonQuery( string commandText)
        {
            // Pass through the call providing null for the set of SqlParameters

            return MySqlHelper.ExecuteNonQuery(Prefrences.MySQlConnectionString, CommandType.Text,commandText);
        }


        public static DataSet ExecuteDataset( string commandText)
        {

            
            return MySqlHelper.ExecuteDataset(Prefrences.MySQlConnectionString, CommandType.Text, commandText);

        }

        public static object ExecuteScalar( string commandText)
        {
            // Pass through the call providing null for the set of SqlParameters
            return MySqlHelper.ExecuteScalar(Prefrences.MySQlConnectionString, CommandType.Text, commandText);
        }

        public static DataRow ExecuteDataRow(string commandText)
        {
           MySqlHelper.ExecuteNonQuery(Prefrences.MySQlConnectionString, CommandType.Text, commandText);

           DataSet ds= MySqlHelper.ExecuteDataset(Prefrences.MySQlConnectionString, CommandType.Text, commandText);
            DataRow dr;
            if(ds.Tables[0].Rows.Count==1){
                dr=ds.Tables[0].Rows[0];
            }
            else
            {
            dr=null;
            }
            return dr;
        }
        public static bool fillGrid(string query, ref DataGridView dg)
        {
            dg.DataSource = MySqlGeneralFunction.ExecuteDataset(query).Tables[0];
            return true;
        }
        public static bool fillGrid(string query,  DataGridView dg)
        {
            dg.DataSource = MySqlGeneralFunction.ExecuteDataset(query).Tables[0];
            return true;
        }
    }
}
