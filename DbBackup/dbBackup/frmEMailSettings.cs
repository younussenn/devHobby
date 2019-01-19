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

namespace dbBackup
{
    public partial class frmEMailSettings : DevExpress.XtraEditors.XtraForm
    {

        mainForm mF;
        public frmEMailSettings(mainForm fParent)
        {
            InitializeComponent();
            mF = fParent;

        }

        public bool mailControl(string eMail)
        {

            return false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFromMail.Text == "")
                    throw new Exception("From E-Mail is Blank ! Please Fill.");

                if (tbFromMailPass.Text == "")
                    throw new Exception("From Mail Password is Blank ! Please Fill.");

                if (tbSmtpHost.Text == "")
                    throw new Exception("From Smtp Host is Blank ! Please Fill.");

                 

                #region SaveEMailSettingsToXML
                DataTable dtEmail = new DataTable("dtEMail");
                dtEmail.Columns.Add("FromEMail");
                dtEmail.Columns.Add("Password");
                dtEmail.Columns.Add("SmtpHost");
                dtEmail.Columns.Add("SmtpPort");
                dtEmail.Columns.Add("EnableSSL");

                if (!File.Exists("dtEMail.xsd"))
                    dtEmail.WriteXmlSchema("dtEMail.xsd");

                DataRow dr = dtEmail.NewRow();

                dr["FromEMail"] = tbFromMail.Text;
                dr["Password"] = EncryptionManager.Encrypt(tbFromMailPass.Text);
                dr["SmtpHost"] = tbSmtpHost.Text;
                dr["SmtpPort"] = spnSmtpPort.Value.ToString();
                if (cbSSL.Checked == true) { dr["EnableSSL"] = "1"; } else dr["EnableSSL"] = "0";


                dtEmail.Rows.Add(dr);

                dtEmail.WriteXml("dtEMail.xml");
                #endregion



                saveEMail(tbFromMail.Text, tbFromMailPass.Text, tbSmtpHost.Text, Convert.ToInt32(spnSmtpPort.Value), Convert.ToBoolean(cbSSL.CheckState));
                Close();





            }
            catch (Exception ex)
            {

                MessageManager.ShowErrorMessage(ex.Message);
            }


            
        }


        public void saveEMail(string FromMail, string FromMailPass, string SmtpHost, int SmtpPort,bool SSL)
        {
            Managers.EMailManager.EMail = FromMail;
            Managers.EMailManager.Pasword = FromMailPass;
            Managers.EMailManager.Smtp = SmtpHost;
            Managers.EMailManager.Port = SmtpPort;
            Managers.EMailManager.EnableSSL = SSL;


        }


        private void Xml_Reader()
        {
            if (File.Exists("dtEMail.xsd"))
            {

                DataTable dtEmail = new DataTable();
                dtEmail.ReadXmlSchema("dtEMail.xsd");

                dtEmail.ReadXml("dtEMail.xml");


                foreach (DataRow dr in dtEmail.Rows)
                {
                    tbFromMail.Text = dr["FromEMail"].ToString();
                    tbFromMailPass.Text = EncryptionManager.Decrypt(dr["Password"].ToString());
                    tbSmtpHost.Text = dr["SmtpHost"].ToString();
                    spnSmtpPort.Value = Convert.ToInt32(dr["SmtpPort"].ToString());

                    if (dr["EnableSSL"].ToString() == "1")
                        cbSSL.Checked = true;
                    else
                        cbSSL.Checked = false;

                    
                     


                }

            }
        }

        private void frmEMailSettings_Load(object sender, EventArgs e)
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
    }
}