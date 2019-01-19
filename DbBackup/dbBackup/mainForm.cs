using dbBackup.Managers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace dbBackup
{
    public partial class mainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        FormManager fm;
        ConnectionManager cm;
        SqlManager sqlManager;
        BackupManager backupManager;
        EMailManager eMailManager;

        string zipName;
        string dbList="";

        public mainForm()
        {
            InitializeComponent();


            fm = new FormManager();
            cm = new ConnectionManager();

            if (File.Exists("dtSetting.xsd"))
            {
                Xml_Reader();
            }

           




        }

        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fm.ShowDialogForm(new frmDbSettings(this));
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

            try
            {
                FillDB();  
            }
            catch (Exception ex)
            {

                MessageManager.ShowErrorMessage(ex.Message);
            }
           
            

        }

        public void FillDB()
        {
            if (GetDatabaseList().Count > 0)
                cblDatabase.DataSource = GetDatabaseList();

        }

 
        public List<string> GetDatabaseList()
        {
            List<string> list = new List<string>();

            sqlManager = new SqlManager();

            if (File.Exists("dtSetting.xsd"))
            {
                using (SqlConnection con = new SqlConnection(sqlManager.SqlConnectionString))
                {

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    if (con.State == ConnectionState.Open)
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
                    ConnectionManager.IsWindowsAuthentication = Convert.ToInt32(dr["IsWindowsAuth"].ToString());
                }

            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                backupManager = new BackupManager();
                
               foreach(var item in cblDatabase.CheckedItems)
               {
                    BackupDbAndCompress(tbPath.Text, backupManager.restoreFileName(tbPath.Text,"",item.ToString()), item.ToString());

                    MessageManager.ShowAlertMessage(this, "Information", "Successfully full backup to database : " + Environment.NewLine +  item.ToString());

                    if (cbEMail.Checked)
                    {
                        if (dbList == "")
                            dbList = item.ToString();
                        else
                            dbList = dbList + Environment.NewLine + item.ToString();
                    }
               }

                if (cbEMail.Checked)
                {
                    sendMail(tbEMail.Text, dbList);

                }

            }
            catch (Exception ex)
            {
                MessageManager.ShowErrorMessage(ex.Message);
            }
        }

        private void cbFolder_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;

            if (edit.Checked == true)
            {
                tbPath.Enabled = true;
                btnFolder.Enabled = true;
                lblFolder.Enabled = true;

           
            }
            else
            {

                tbPath.Enabled = false;
                btnFolder.Enabled = false;
                lblFolder.Enabled = false;

                tbPath.Text = "";


            }
        }

        private void cbEMail_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked == true)
            {
                tbEMail.Enabled = true;
                btnEmailSettings.Enabled = true;
                lblEMail.Enabled = true;

               
                 
            }
            else
            {

                tbEMail.Enabled = false;
                btnEmailSettings.Enabled = false;
                lblEMail.Enabled = false;

                tbEMail.Text = "";

            }
        }


        public void BackupDbAndCompress(string path,string fileName,string database)
        {

            try
            {

                if (!Directory.Exists(path))
                {
                    throw new Exception("This path not found!");
                }

                string queery = "BACKUP DATABASE " + database + " TO DISK = '" + fileName + "'";


                using (SqlConnection con = new SqlConnection(sqlManager.SqlConnectionString))
                {

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand(queery, con))
                        {
                            cmd.ExecuteNonQuery();

                        }
                    }
                }


                zipName = fileName.Replace(".bak", ".zip");

                backupManager.zipBackupFile(fileName, zipName, 1024);








            }
            catch (Exception ex)
            {

                MessageManager.ShowErrorMessage(ex.Message);
                
            }



        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            xtraFolderBrowserDialog1.ShowDialog();
            tbPath.Text = xtraFolderBrowserDialog1.SelectedPath;
        }


        //public void writeXmlBackupParameter()
        //{

        //    DataTable dtSetting = new DataTable("dtBackupParameter");
        //    dtSetting.Columns.Add("backupPath");
        //    dtSetting.Columns.Add("isPath");
        //    dtSetting.Columns.Add("backupEmail");
        //    dtSetting.Columns.Add("isEmail");

        //    if (!File.Exists("dtBackupParameter.xsd"))
        //        dtSetting.WriteXmlSchema("dtBackupParameter.xsd");

        //    DataRow dr = dtSetting.NewRow();

        //    if (cbFolder.Checked)
        //    {
        //        dr["backupPath"] = tbPath.Text;
        //        dr["isPath"] = "1";
        //    }
        //    else
        //    {
        //        dr["backupPath"] = "";
        //        dr["isPath"] = "0";
        //    }


        //    if (cbEMail.Checked)
        //    {
        //        dr["backupEmail"] = "";
        //        dr["isEmail"] = "1";

        //    }
        //    else
        //    {
        //        dr["backupEmail"] = "";
        //        dr["isEmail"] = "0";
        //    }

        //    dtSetting.Rows.Add(dr);

        //    dtSetting.WriteXml("dtBackupParameter.xml");


        //}

        //public void readXmlBackupParameter()
        //{
        //    if (File.Exists("dtBackupParameter.xsd"))
        //    {

        //        DataTable dtSetting = new DataTable();
        //        dtSetting.ReadXmlSchema("dtBackupParameter.xsd");

        //        dtSetting.ReadXml("dtBackupParameter.xml");


        //        foreach (DataRow dr in dtSetting.Rows)
        //        {

        //            if(dr["isPath"].ToString() == "1")
        //                BackupManager.IsPath = true;
        //            else
        //                BackupManager.IsPath = false;

        //            if (dr["isEmail"].ToString() == "1")
        //                BackupManager.IsEMail = true;
        //            else
        //                BackupManager.IsEMail = false;


        //            BackupManager.BackupPath = dr["backupPath"].ToString();
        //            BackupManager.BackupPath = dr["backupEmail"].ToString();



        //        }

        //    }

        //}

        //public void FillBackupParameter()
        //{

        //}


        void sendMail(string toEMail,string backupedDb)
        {

            if(cbEMail.Checked)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(toEMail);
                mail.From = new MailAddress(EMailManager.EMail);
                mail.Subject = "Backup Info";
                mail.Body = "Hi , " + Environment.NewLine + "BACKUPED Database List" + Environment.NewLine + "----------------------" + backupedDb + Environment.NewLine + Environment.NewLine + "SUCCESS BACKUP";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = EMailManager.Smtp; 
                smtp.Credentials = new System.Net.NetworkCredential(EMailManager.EMail, EMailManager.Pasword);
                smtp.Port = EMailManager.Port;
                smtp.EnableSsl = EMailManager.EnableSSL;
                smtp.Send(mail);
                MessageManager.ShowAlertMessage(this,"Info",tbEMail.Text + " Mail Sended");
            }
        }

        private void btnEmailSettings_Click(object sender, EventArgs e)
        {
            fm.ShowDialogForm(new frmEMailSettings(this));
        }
    }
}
