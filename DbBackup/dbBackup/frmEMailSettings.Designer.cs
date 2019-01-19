namespace dbBackup
{
    partial class frmEMailSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEMailSettings));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbSSL = new DevExpress.XtraEditors.CheckEdit();
            this.tbFromMail = new DevExpress.XtraEditors.TextEdit();
            this.tbFromMailPass = new DevExpress.XtraEditors.TextEdit();
            this.tbSmtpHost = new DevExpress.XtraEditors.TextEdit();
            this.spnSmtpPort = new DevExpress.XtraEditors.SpinEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbSSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFromMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFromMailPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmtpHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSmtpPort.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "McSkin";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "From E-Mail";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Smtp Host";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(363, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Smtp Port";
            // 
            // cbSSL
            // 
            this.cbSSL.Location = new System.Drawing.Point(363, 121);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Properties.Caption = "Enable SSL";
            this.cbSSL.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.cbSSL.Size = new System.Drawing.Size(123, 20);
            this.cbSSL.TabIndex = 4;
            // 
            // tbFromMail
            // 
            this.tbFromMail.Location = new System.Drawing.Point(124, 30);
            this.tbFromMail.Name = "tbFromMail";
            this.tbFromMail.Size = new System.Drawing.Size(362, 23);
            this.tbFromMail.TabIndex = 5;
            // 
            // tbFromMailPass
            // 
            this.tbFromMailPass.Location = new System.Drawing.Point(124, 59);
            this.tbFromMailPass.Name = "tbFromMailPass";
            this.tbFromMailPass.Size = new System.Drawing.Size(362, 23);
            this.tbFromMailPass.TabIndex = 6;
            // 
            // tbSmtpHost
            // 
            this.tbSmtpHost.Location = new System.Drawing.Point(124, 91);
            this.tbSmtpHost.Name = "tbSmtpHost";
            this.tbSmtpHost.Size = new System.Drawing.Size(233, 23);
            this.tbSmtpHost.TabIndex = 7;
            // 
            // spnSmtpPort
            // 
            this.spnSmtpPort.EditValue = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.spnSmtpPort.Location = new System.Drawing.Point(426, 89);
            this.spnSmtpPort.Name = "spnSmtpPort";
            this.spnSmtpPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnSmtpPort.Properties.IsFloatValue = false;
            this.spnSmtpPort.Properties.Mask.EditMask = "N00";
            this.spnSmtpPort.Size = new System.Drawing.Size(60, 26);
            this.spnSmtpPort.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(358, 160);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(125, 32);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save && Close";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmEMailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 203);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.spnSmtpPort);
            this.Controls.Add(this.tbSmtpHost);
            this.Controls.Add(this.tbFromMailPass);
            this.Controls.Add(this.tbFromMail);
            this.Controls.Add(this.cbSSL);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEMailSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Mail Settings";
            this.Load += new System.EventHandler(this.frmEMailSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbSSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFromMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFromMailPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmtpHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnSmtpPort.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit cbSSL;
        private DevExpress.XtraEditors.TextEdit tbFromMail;
        private DevExpress.XtraEditors.TextEdit tbFromMailPass;
        private DevExpress.XtraEditors.TextEdit tbSmtpHost;
        private DevExpress.XtraEditors.SpinEdit spnSmtpPort;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
    }
}