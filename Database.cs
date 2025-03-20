using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAGASCO
{
    internal class Database
    {
        private readonly string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\Abella, Wayen\\OOPAGASCODATABASE.accdb";
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        OleDbConnection? myConn;

        public Database()
        {
            myConn = new OleDbConnection(connectionString);
        }
       
        public void testconnection()
        {
            myConn = new OleDbConnection(connectionString);
            ds = new DataSet();
            myConn.Open();
            MessageBox.Show("Connected Successfully!");
            myConn.Close();
        }
    }
}
