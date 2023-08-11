using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;

namespace StudyWPFSQLite.DB
{
    public static class DBMain
    {
        public static void GetSQLiteVersion()
        {
            string connStr = @"Data Source = D:\MySQLite\Study\HelloWorld\mysqlite.db";
            string stm = "SELECT SQLITE_VERSION()";

            var con = new SQLiteConnection(connStr);
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();

            
        }
    }
}
