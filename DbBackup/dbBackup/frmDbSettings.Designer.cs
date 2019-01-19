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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DbPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(334, 231);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(125, 32);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save && Close";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Test.ImageOptions.Image")));
            this.btn_Test.Location = new System.Drawing.Point(12, 231);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(170, 32);
            this.btn_Test.TabIndex = 5;
            this.btn_Test.Text = "Test SQL Connection";
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // tb_DbPass
            // 
            this.tb_DbPass.Enabled = false;
            this.tb_DbPass.Location = new System.Drawing.Point(134, 123);
            this.tb_DbPass.Name = "tb_DbPass";
            this.tb_DbPass.Properties.PasswordChar = '*';
            this.tb_DbPass.Size = new System.Drawing.Size(274, 23);
            this.tb_DbPass.TabIndex = 4;
            // 
            // tb_DbUser
            // 
            this.tb_DbUser.Enabled = false;
            this.tb_DbUser.Location = new System.Drawing.Point(134, 95);
            this.tb_DbUser.Name = "tb_DbUser";
            this.tb_DbUser.Size = new System.Drawing.Size(274, 23);
            this.tb_DbUser.TabIndex = 3;
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(126, 12);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(333, 23);
            this.tb_Server.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 16);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 16);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "User";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 16);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Server Name :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.tb_DbPass);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.tb_DbUser);
            this.groupControl1.Location = new System.Drawing.Point(13, 52);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(432, 173);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Log on the server";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(5, 30);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroup1.Properties.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Near;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Use Windows Authentication"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Use SQL Server Authentication")});
            this.radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioGroup1.Properties.LookAndFeel.SkinName = "McSkin";
            this.radioGroup1.Size = new System.Drawing.Size(375, 62);
            this.radioGroup1.TabIndex = 2;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // frmDbSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 272);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.tb_Server);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "McSkin";
            this.Name = "frmDbSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Db Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDbSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmDbSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_DbPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}