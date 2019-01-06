namespace dbBackup
{
    partial class frmDbSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDbSettings));
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Test = new DevExpress.XtraEditors.SimpleButton();
            this.tb_DbPass = new DevExpress.XtraEditors.TextEdit();
            this.tb_DbUser = new DevExpress.XtraEditors.TextEdit();
            this.tb_Server = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DbPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Server.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(302, 138);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 32);
            this.btn_Save.TabIndex = 29;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Test.ImageOptions.Image")));
            this.btn_Test.Location = new System.Drawing.Point(35, 138);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(129, 32);
            this.btn_Test.TabIndex = 28;
            this.btn_Test.Text = "Bağlantıyı Test Et";
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // tb_DbPass
            // 
            this.tb_DbPass.Location = new System.Drawing.Point(146, 100);
            this.tb_DbPass.Name = "tb_DbPass";
            this.tb_DbPass.Size = new System.Drawing.Size(241, 23);
            this.tb_DbPass.TabIndex = 27;
            // 
            // tb_DbUser
            // 
            this.tb_DbUser.Location = new System.Drawing.Point(146, 72);
            this.tb_DbUser.Name = "tb_DbUser";
            this.tb_DbUser.Size = new System.Drawing.Size(241, 23);
            this.tb_DbUser.TabIndex = 26;
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(146, 16);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(241, 23);
            this.tb_Server.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 16);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Şifre";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 16);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Kullanıcı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 16);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Sunucu";
            // 
            // frmDbSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 187);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.tb_DbPass);
            this.Controls.Add(this.tb_DbUser);
            this.Controls.Add(this.tb_Server);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "McSkin";
            this.Name = "frmDbSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Db Settings";
            ((System.ComponentModel.ISupportInitialize)(this.tb_DbPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Server.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Test;
        private DevExpress.XtraEditors.TextEdit tb_DbPass;
        private DevExpress.XtraEditors.TextEdit tb_DbUser;
        private DevExpress.XtraEditors.TextEdit tb_Server;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}