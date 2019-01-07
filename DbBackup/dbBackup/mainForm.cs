using dbBackup.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbBackup
{
    public partial class mainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        FormManager fm;
        ConnectionManager cm;
        SqlManager sqlManager;

        public mainForm()
        {
            InitializeComponent();


            fm = new FormManager();
            cm = new ConnectionManager();

            Xml_Reader();
            sqlManager = new SqlManager();

            
        }

        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fm.ShowDialogForm(new frmDbSettings());
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

            try
            {
                if (GetDatabaseList().Count > 0)
                    cblDatabase.DataSource = GetDatabaseList();
            }
            catch (Exception ex)
            {

                MessageManager.ShowErrorMessage(ex.Message);
            }
           
            

        }

        public List<string> GetDatabaseList()
        {
            List<string> list = new List<string>();


            

            using (SqlConnection con = new SqlConnection(sqlManager.SqlConnectionString))
            {

                if (con.State == ConnectionState.Closed)
                    con.Open();

                if(con.State == ConnectionState.Open)
                { 
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                list.Add(dr[0].ToString());
                            }
                        }
                    }
                }
            }
            return list;

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
                    ConnectionManager.ServerName= dr["Server"].ToString();
                    ConnectionManager.User = dr["User"].ToString();
                    ConnectionManager.Password = EncryptionManager.Decrypt(dr["Password"].ToString());
                }

            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }
    }
}
