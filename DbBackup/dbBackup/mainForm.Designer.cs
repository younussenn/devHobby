﻿namespace dbBackup
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.barText = new DevExpress.XtraBars.BarStaticItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.rbBackup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.taskbarAssistant1 = new DevExpress.Utils.Taskbar.TaskbarAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cblDatabase = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cbFolder = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblFolder = new DevExpress.XtraEditors.LabelControl();
            this.btnFolder = new DevExpress.XtraEditors.SimpleButton();
            this.tbPath = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblEMail = new DevExpress.XtraEditors.LabelControl();
            this.btnEmailSettings = new DevExpress.XtraEditors.SimpleButton();
            this.tbEMail = new DevExpress.XtraEditors.TextEdit();
            this.cbEMail = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.btnRun = new DevExpress.XtraEditors.SimpleButton();
            this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cblDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSettings,
            this.btnBackup,
            this.barText,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbBackup,
            this.rbSettings});
            this.ribbonControl1.Size = new System.Drawing.Size(1039, 187);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "Db Config";
            this.btnSettings.Id = 1;
            this.btnSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.Image")));
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSettings_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Db Backup Schedule";
            this.btnBackup.Id = 2;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barText
            // 
            this.barText.Id = 3;
            this.barText.Name = "barText";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            // 
            // 
            // 
            this.skinRibbonGalleryBarItem1.Gallery.ShowItemText = true;
            this.skinRibbonGalleryBarItem1.Id = 5;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // rbBackup
            // 
            this.rbBackup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbBackup.Name = "rbBackup";
            this.rbBackup.Text = "Database Backup";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Backup Form";
            // 
            // rbSettings
            // 
            this.rbSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbSettings.Name = "rbSettings";
            this.rbSettings.Text = "Settings";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSettings);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Database Settings";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barText);
            this.ribbonStatusBar1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 630);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1039, 35);
            // 
            // taskbarAssistant1
            // 
            this.taskbarAssistant1.ParentControl = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "McSkin";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.cblDatabase);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 187);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(221, 443);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Databases";
            // 
            // cblDatabase
            // 
            this.cblDatabase.Appearance.BackColor = System.Drawing.Color.Silver;
            this.cblDatabase.Appearance.ForeColor = System.Drawing.Color.White;
            this.cblDatabase.Appearance.Options.UseBackColor = true;
            this.cblDatabase.Appearance.Options.UseForeColor = true;
            this.cblDatabase.Cursor = System.Windows.Forms.Cursors.Default;
            this.cblDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cblDatabase.Location = new System.Drawing.Point(2, 41);
            this.cblDatabase.Name = "cblDatabase";
            this.cblDatabase.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.cblDatabase.Size = new System.Drawing.Size(217, 400);
            this.cblDatabase.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Size = new System.Drawing.Size(1039, 649);
            this.splitContainerControl1.SplitterPosition = 166;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // cbFolder
            // 
            this.cbFolder.Location = new System.Drawing.Point(5, 5);
            this.cbFolder.MenuManager = this.ribbonControl1;
            this.cbFolder.Name = "cbFolder";
            this.cbFolder.Properties.Caption = "Store Backups in a Local/Network Folder";
            this.cbFolder.Size = new System.Drawing.Size(273, 20);
            this.cbFolder.TabIndex = 5;
            this.cbFolder.CheckedChanged += new System.EventHandler(this.cbFolder_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblFolder);
            this.panelControl1.Controls.Add(this.btnFolder);
            this.panelControl1.Controls.Add(this.tbPath);
            this.panelControl1.Controls.Add(this.cbFolder);
            this.panelControl1.Location = new System.Drawing.Point(227, 194);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 116);
            this.panelControl1.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(168, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(337, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Full Database Backup stored like \"YYYYmmdd_DbName.zip\"";
            // 
            // lblFolder
            // 
            this.lblFolder.Enabled = false;
            this.lblFolder.Location = new System.Drawing.Point(23, 45);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(130, 16);
            this.lblFolder.TabIndex = 8;
            this.lblFolder.Text = "Local/Network Folder :";
            // 
            // btnFolder
            // 
            this.btnFolder.Enabled = false;
            this.btnFolder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFolder.ImageOptions.Image")));
            this.btnFolder.Location = new System.Drawing.Point(717, 34);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(42, 37);
            this.btnFolder.TabIndex = 7;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(168, 42);
            this.tbPath.MenuManager = this.ribbonControl1;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(543, 23);
            this.tbPath.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.lblEMail);
            this.panelControl2.Controls.Add(this.btnEmailSettings);
            this.panelControl2.Controls.Add(this.tbEMail);
            this.panelControl2.Controls.Add(this.cbEMail);
            this.panelControl2.Location = new System.Drawing.Point(227, 316);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 123);
            this.panelControl2.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(141, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(240, 16);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Subject will be \"Success/Failure DbName\"";
            // 
            // lblEMail
            // 
            this.lblEMail.Enabled = false;
            this.lblEMail.Location = new System.Drawing.Point(23, 45);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(85, 16);
            this.lblEMail.TabIndex = 8;
            this.lblEMail.Text = "E-Mail Address";
            // 
            // btnEmailSettings
            // 
            this.btnEmailSettings.Enabled = false;
            this.btnEmailSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmailSettings.ImageOptions.Image")));
            this.btnEmailSettings.Location = new System.Drawing.Point(612, 71);
            this.btnEmailSettings.Name = "btnEmailSettings";
            this.btnEmailSettings.Size = new System.Drawing.Size(147, 37);
            this.btnEmailSettings.TabIndex = 7;
            this.btnEmailSettings.Text = "E-Mail Settings";
            this.btnEmailSettings.Click += new System.EventHandler(this.btnEmailSettings_Click);
            // 
            // tbEMail
            // 
            this.tbEMail.Enabled = false;
            this.tbEMail.Location = new System.Drawing.Point(141, 42);
            this.tbEMail.MenuManager = this.ribbonControl1;
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(618, 23);
            this.tbEMail.TabIndex = 6;
            // 
            // cbEMail
            // 
            this.cbEMail.Location = new System.Drawing.Point(5, 5);
            this.cbEMail.MenuManager = this.ribbonControl1;
            this.cbEMail.Name = "cbEMail";
            this.cbEMail.Properties.Caption = "Send E-Mail Confimations";
            this.cbEMail.Size = new System.Drawing.Size(273, 20);
            this.cbEMail.TabIndex = 5;
            this.cbEMail.CheckedChanged += new System.EventHandler(this.cbEMail_CheckedChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.timeEdit1);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.checkEdit2);
            this.panelControl3.Location = new System.Drawing.Point(227, 454);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(800, 115);
            this.panelControl3.TabIndex = 8;
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2019, 1, 7, 0, 0, 0, 0);
            this.timeEdit1.Enabled = false;
            this.timeEdit1.Location = new System.Drawing.Point(141, 42);
            this.timeEdit1.MenuManager = this.ribbonControl1;
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.timeEdit1.Size = new System.Drawing.Size(154, 23);
            this.timeEdit1.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Enabled = false;
            this.labelControl5.Location = new System.Drawing.Point(328, 45);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(241, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Windows Task Scheduler will start the job";
            // 
            // labelControl6
            // 
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Enabled = false;
            this.labelControl6.Location = new System.Drawing.Point(23, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 16);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Job Start Time";
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(5, 5);
            this.checkEdit2.MenuManager = this.ribbonControl1;
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Schedule to run this job daily";
            this.checkEdit2.Size = new System.Drawing.Size(273, 20);
            this.checkEdit2.TabIndex = 5;
            // 
            // btnRun
            // 
            this.btnRun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.ImageOptions.Image")));
            this.btnRun.Location = new System.Drawing.Point(870, 575);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(157, 49);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "RUN NOW";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // xtraFolderBrowserDialog1
            // 
            this.xtraFolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            this.xtraFolderBrowserDialog1.SelectedPath = "xtraFolderBrowserDialog1";
            this.xtraFolderBrowserDialog1.Title = "Select Folder";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 665);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.Ribbon = this.ribbonControl1;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Database Backup";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cblDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBackup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.Utils.Taskbar.TaskbarAssistant taskbarAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl cblDatabase;
        private DevExpress.XtraBars.BarStaticItem barText;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblEMail;
        private DevExpress.XtraEditors.SimpleButton btnEmailSettings;
        private DevExpress.XtraEditors.TextEdit tbEMail;
        private DevExpress.XtraEditors.CheckEdit cbEMail;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblFolder;
        private DevExpress.XtraEditors.SimpleButton btnFolder;
        private DevExpress.XtraEditors.TextEdit tbPath;
        private DevExpress.XtraEditors.CheckEdit cbFolder;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraEditors.SimpleButton btnRun;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
    }
}

