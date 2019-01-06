﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace marketimmApp.Managers
{
    public class SqlManager
    {
        internal string SqlConnectionString { get; set; }
        public int CommandTimeOut { get; set; }


        public SqlManager()
        {
            //SqlConnectionString = "Data Source='" + ConnectionInfo.ServerName + "';Initial Catalog='" + ConnectionInfo.Database + "';Persist Security Info=True;User ID='" + ConnectionInfo.User + "';Password='" + ConnectionInfo.User+"'";

            SqlConnectionString = "Data Source=" + ConnectionManager.ServerName + ";Initial Catalog=" + ConnectionManager.Database + ";Integrated Security=True;";// + ConnectionManager.User + ";Password=" + ConnectionManager.Password + "'";


            // SqlConnectionString = "Data Source='" + ConnectionManager.ServerName + "';Initial Catalog='" + ConnectionManager.Database + "';User ID='" + ConnectionManager.User + "';Password='" + ConnectionManager.Password + "'";

        }

        public void ExecuteNonQueryTestConnect(string _text, int timeOut)
        {
            SqlConnection _connection = new SqlConnection(SqlConnectionString);
            SqlCommand _Command = new SqlCommand(_text, _connection);

            _Command.CommandTimeout = timeOut;

            try
            {
                _connection.Open();
                _Command.Transaction = _connection.BeginTransaction();
                _Command.ExecuteNonQuery();
                _Command.Transaction.Commit();

            }
            catch (SqlException ex)
            {

            }
            finally
            {
                _connection.Close();

                _Command.Dispose();
                _connection.Dispose();
            }


        }
        public void ConnectionTest()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlConnectionString))
                {
                    try
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open) // if connection.Open was successful
                        {

                        }
                        else
                        {
                            MessageManager.ShowErrorMessage("Bağlantı başarısız! Lütfen bilgilerinizi kontrol ediniz.");
                        }
                    }
                    catch (SqlException)
                    {
                        MessageManager.ShowErrorMessage("Bağlantı başarısız! Lütfen bilgilerinizi kontrol ediniz.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageManager.ShowErrorMessage(ex.Message);
            }
        }


        public DataTable ExecuteDataTable(string spName, Dictionary<string, object> parameters)
        {
            DataTable dataTable = new DataTable(spName);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = this.SqlConnectionString;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(spName, con);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    object obj = parameter.Value;
                    if (parameter.Value != null && parameter.Value.GetType().ToString() == "System.String")
                        obj = (object)parameter.Value.ToString().Replace("*", "%");
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@" + parameter.Key, obj);
                }
            }
            try
            {
                sqlDataAdapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                MessageManager.ShowErrorMessage(ex.Message);

            }

            return dataTable;
        }


        public DataTable ExecuteDataTable(string spName, Dictionary<string, object> parameters, SqlConnection _con)
        {
            DataTable dataTable = new DataTable(spName);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(spName, _con);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    object obj = parameter.Value;
                    if (parameter.Value != null && parameter.Value.GetType().ToString() == "System.String")
                        obj = (object)parameter.Value.ToString().Replace("*", "%");
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@" + parameter.Key, obj);
                }
            }
            try
            {
                sqlDataAdapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }


        

    }
}