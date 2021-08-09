using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_Management_System
{
    class Database
    {
        public SqlConnection cnn { get; set; }
        
        public Database()
        {
            cnn = new SqlConnection(@"Server=DESKTOP-H08NNT4\MSSQLSERVER01;Database=LibraryDB;Trusted_Connection=True;");
        }
        public void Connect()
        {
            cnn.Open();
        }

        public void Disconnect()
        {
            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
        }

        public SqlCommand CreateCommand(string query)
        {
            return new SqlCommand(query, cnn);
        }

        public void AddParameter(SqlCommand cmd, string parameter, object value)
        {
            if (value == null)
                cmd.Parameters.AddWithValue(parameter, DBNull.Value);
            else
                cmd.Parameters.AddWithValue(parameter, value);
        }

        public DataTable GetData(string tableName, string columns, DataSet dataSet)
        {
            try
            {
                Connect();
                string queryString = String.Format("select {1} from {0};", tableName, columns);
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, cnn);
                dataSet.Tables.Add(tableName);
                adapter.Fill(dataSet, tableName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return dataSet.Tables[tableName];
        }

        public void UpdateDataTable(DataTable dt)
        {
            try
            {
                Connect();

                string queryString = String.Format("select * from {0};", dt.TableName);

                SqlDataAdapter myDataAdapter = new SqlDataAdapter(queryString, cnn);
                myDataAdapter.SelectCommand = new SqlCommand(queryString, cnn);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(myDataAdapter);

                // Check the DataTable for errors.
                //if (xDataTable.HasErrors)
                //{
                //    // Insert code to resolve errors.
                //}

                myDataAdapter.Update(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}