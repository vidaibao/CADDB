using System;

using Autodesk.AutoCAD.Runtime;
using System.Data.SqlClient;

namespace CADDB
{
    public static class DBUtil
    {


        [CommandMethod("dbrun")]
        public static void DBRun()
        {
            Main main = new Main();
            main.ShowDialog();
        }



        public static SqlConnection GetConnection()
        {
            //string connStr = Settings1.Default.connectstring;
            //SqlConnection conn = new SqlConnection(connStr);
            //return conn;
            return new SqlConnection(Settings1.Default.connectstring);
        }



    }
}
