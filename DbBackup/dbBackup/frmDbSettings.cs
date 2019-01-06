using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using dbBackup.Managers;
using System.Data.SqlClient;

namespace dbBackup
{
    public partial class frmDbSettings : DevExpress.XtraEditors.XtraForm
    {

        private string TestConnectionString;
        public frmDbSettings()
        {
            InitializeComponent();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            if (tb_DbUser.Text == "" && tb_DbPass.Text == "")
            {
                TestConnectionString = "Data Source=" + tb_Server.Text + ";Initial Catalog=" +"master"+ ";Integrated Security=True;";


            }
            else
            {
                TestConnectionString = "Data Source='" + tb_Server.Text + "';Initial Catalog='" + "master" + "';User ID='" + tb_DbUser.Text + "';Password='" + tb_DbPass.Text + "'";

            }

            try
            {
                using (SqlConnection connection = new SqlConnection(TestConnectionString))
                {
                    try
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open) //Baglanti basarili mi?
                        {
                            MessageManager.ShowInfoMessage("Test connection succeeded");
                        }
                        else
                        {
                            MessageManager.ShowErrorMessage("Connection failed! Please check the connection information.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageManager.ShowErrorMessage("Connection failed! Please check the connection information.");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            #region SaveSqlConnectionStringToXml 
            DataTable dtSetting = new DataTable("dtSetting");
            dtSetting.Columns.Add("Server");
            dtSetting.Columns.Add("User");
            dtSetting.Columns.Add("Password");
            dtSetting.Columns.Add("IsWindowsAuth");

            if (!File.Exists("dtSetting.xsd"))
                dtSetting.WriteXmlSchema("dtSetting.xsd");

            DataRow dr = dtSetting.NewRow();

            dr["Server"] = tb_Server.Text;
            dr["User"] = tb_DbUser.Text;
            dr["Password"] = EncryptionManager.Encrypt(tb_DbPass.Text);
            dr["IsWindowsAuth"] = radioGroup1.SelectedIndex.ToString();


            dtSetting.Rows.Add(dr);

            dtSetting.WriteXml("dtSetting.xml");
            #endregion


            connectSQLSERVER(tb_Server.Text, tb_DbUser.Text, tb_DbPass.Text);
            Close();

        }

        private void Xml_Reader()
        {
            if (File.Exists("dtSetting.xsd"))
            {

                DataTable dtSetting = new DataTable();
                dtSetting.ReadXmlSchema("dtSetting.xsd");

                dtSetting.ReadXml("dtSetting.xml");


                foreach (DataRow dr in dtSetting.Rows)
                {
                    tb_Server.Text = dr["Server"].ToString();

                    radioGroup1.SelectedIndex = Convert.ToInt32(dr["IsWindowsAuth"].ToString());
                    tb_DbUser.Text = dr["User"].ToString();
                    tb_DbPass.Text = EncryptionManager.Decrypt(dr["Password"].ToString());


                }

            }
        }


        public void connectSQLSERVER(string server,string user, string password)
        {
            Managers.ConnectionManager.ServerName = server;
            Managers.ConnectionManager.User = user;
            Managers.ConnectionManager.Password = password;

        }

        private void frmDbSettings_Load(object sender, EventArgs e)
        {
            try
            {
                Xml_Reader();
            }
            catch (Exception ex)
            {
                MessageManager.ShowErrorMessage(ex.Message);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;
            if (edit.SelectedIndex == 0)
            {
                tb_DbUser.Enabled = false;
                tb_DbPass.Enabled = false;
            }
            else
            {
                tb_DbUser.Enabled = true;
                tb_DbPass.Enabled = true;
            }
        }
    }
}