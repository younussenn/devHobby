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
            sqlManager = new SqlManager();

            
        }

        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fm.ShowDialogForm(new frmDbSettings());
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if(GetDatabaseList().Count > 0)
                cblDatabase.DataSource = GetDatabaseList();
            

        }

        public List<string> GetDatabaseList()
        {
            List<string> list = new List<string>();


            

            using (SqlConnection con = new SqlConnection(sqlManager.SqlConnectionString))
            {
                
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

        
        //private void Xml_Reader()
        //{
        //    if (File.Exists("dtSetting.xsd"))
        //    {

        //        DataTable dtSetting = new DataTable();
        //        dtSetting.ReadXmlSchema("dtSetting.xsd");

        //        dtSetting.ReadXml("dtSetting.xml");


        //        foreach (DataRow dr in dtSetting.Rows)
        //        {
        //            tb_Server.Text = dr["Server"].ToString();

        //            radioGroup1.SelectedIndex = Convert.ToInt32(dr["IsWindowsAuth"].ToString());
        //            tb_DbUser.Text = dr["User"].ToString();
        //            tb_DbPass.Text = EncryptionManager.Decrypt(dr["Password"].ToString());


        //        }

        //    }
        //}

    }
}
