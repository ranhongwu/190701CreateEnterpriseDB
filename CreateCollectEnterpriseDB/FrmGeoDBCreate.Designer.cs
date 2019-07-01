namespace CreateCollectEnterpriseDB
{
    partial class FrmCreateEneDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateEneDB));
            this.combxDBPlatform = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tbxInstance = new DevExpress.XtraEditors.TextEdit();
            this.tbxDB_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbox_DB_pwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbox_DB_admin = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tbox_GDB_pwd = new DevExpress.XtraEditors.TextEdit();
            this.tbox_GDB_admin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tboxEcpFile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_FileBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            ((System.ComponentModel.ISupportInitialize)(this.combxDBPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxInstance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDB_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_DB_pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_DB_admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_GDB_pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_GDB_admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxEcpFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // combxDBPlatform
            // 
            this.combxDBPlatform.Location = new System.Drawing.Point(89, 12);
            this.combxDBPlatform.Name = "combxDBPlatform";
            this.combxDBPlatform.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combxDBPlatform.Properties.Items.AddRange(new object[] {
            "SQL_Srever",
            "PostgreSQL",
            "Oracle"});
            this.combxDBPlatform.Size = new System.Drawing.Size(218, 20);
            this.combxDBPlatform.TabIndex = 0;
            this.combxDBPlatform.SelectedIndexChanged += new System.EventHandler(this.combxDBPlatform_SelectedIndexChanged);
            // 
            // tbxInstance
            // 
            this.tbxInstance.Location = new System.Drawing.Point(89, 41);
            this.tbxInstance.Name = "tbxInstance";
            this.tbxInstance.Size = new System.Drawing.Size(218, 20);
            this.tbxInstance.TabIndex = 1;
            this.tbxInstance.EditValueChanged += new System.EventHandler(this.tbxInstance_EditValueChanged);
            // 
            // tbxDB_Name
            // 
            this.tbxDB_Name.Location = new System.Drawing.Point(89, 69);
            this.tbxDB_Name.Name = "tbxDB_Name";
            this.tbxDB_Name.Size = new System.Drawing.Size(218, 20);
            this.tbxDB_Name.TabIndex = 2;
            this.tbxDB_Name.EditValueChanged += new System.EventHandler(this.tbxDB_Name_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "数据库类型：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "IP地址：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "数据库名称：";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tbox_DB_pwd);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.tbox_DB_admin);
            this.groupControl1.Location = new System.Drawing.Point(12, 106);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(295, 84);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "数据库身份验证";
            // 
            // tbox_DB_pwd
            // 
            this.tbox_DB_pwd.Location = new System.Drawing.Point(77, 53);
            this.tbox_DB_pwd.Name = "tbox_DB_pwd";
            this.tbox_DB_pwd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbox_DB_pwd.Properties.PasswordChar = '·';
            this.tbox_DB_pwd.Properties.UseSystemPasswordChar = true;
            this.tbox_DB_pwd.Size = new System.Drawing.Size(208, 20);
            this.tbox_DB_pwd.TabIndex = 10;
            this.tbox_DB_pwd.EditValueChanged += new System.EventHandler(this.tbox_DB_pwd_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "密码：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "用户名：";
            // 
            // tbox_DB_admin
            // 
            this.tbox_DB_admin.EditValue = "postgres";
            this.tbox_DB_admin.Location = new System.Drawing.Point(77, 27);
            this.tbox_DB_admin.Name = "tbox_DB_admin";
            this.tbox_DB_admin.Size = new System.Drawing.Size(208, 20);
            this.tbox_DB_admin.TabIndex = 8;
            this.tbox_DB_admin.EditValueChanged += new System.EventHandler(this.tbox_DB_admin_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tbox_GDB_pwd);
            this.groupControl2.Controls.Add(this.tbox_GDB_admin);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Location = new System.Drawing.Point(11, 204);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(296, 84);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "地理数据库身份验证";
            // 
            // tbox_GDB_pwd
            // 
            this.tbox_GDB_pwd.Location = new System.Drawing.Point(77, 52);
            this.tbox_GDB_pwd.Name = "tbox_GDB_pwd";
            this.tbox_GDB_pwd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbox_GDB_pwd.Properties.PasswordChar = '·';
            this.tbox_GDB_pwd.Properties.UseSystemPasswordChar = true;
            this.tbox_GDB_pwd.Size = new System.Drawing.Size(209, 20);
            this.tbox_GDB_pwd.TabIndex = 14;
            this.tbox_GDB_pwd.EditValueChanged += new System.EventHandler(this.tbox_GDB_pwd_EditValueChanged);
            // 
            // tbox_GDB_admin
            // 
            this.tbox_GDB_admin.EditValue = "sde";
            this.tbox_GDB_admin.Enabled = false;
            this.tbox_GDB_admin.Location = new System.Drawing.Point(77, 26);
            this.tbox_GDB_admin.Name = "tbox_GDB_admin";
            this.tbox_GDB_admin.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.tbox_GDB_admin.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.tbox_GDB_admin.Size = new System.Drawing.Size(209, 20);
            this.tbox_GDB_admin.TabIndex = 12;
            this.tbox_GDB_admin.EditValueChanged += new System.EventHandler(this.tbox_GDB_admin_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "密码：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 29);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "用户名：";
            // 
            // tboxEcpFile
            // 
            this.tboxEcpFile.Location = new System.Drawing.Point(89, 303);
            this.tboxEcpFile.Name = "tboxEcpFile";
            this.tboxEcpFile.Size = new System.Drawing.Size(184, 20);
            this.tboxEcpFile.TabIndex = 15;
            this.tboxEcpFile.EditValueChanged += new System.EventHandler(this.tboxEcpFile_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 306);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "许可文件：";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(232, 339);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "确定";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(89, 339);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 18;
            this.simpleButton3.Text = "取消";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_FileBrowser
            // 
            this.btn_FileBrowser.ImageOptions.Image = global::CreateCollectEnterpriseDB.Properties.Resources.open_16x16;
            this.btn_FileBrowser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_FileBrowser.Location = new System.Drawing.Point(282, 300);
            this.btn_FileBrowser.Name = "btn_FileBrowser";
            this.btn_FileBrowser.Size = new System.Drawing.Size(25, 25);
            this.btn_FileBrowser.TabIndex = 16;
            this.btn_FileBrowser.Click += new System.EventHandler(this.btn_FileBrowser_Click);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(-1, 339);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 20;
            // 
            // FrmCreateEneDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 371);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btn_FileBrowser);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tboxEcpFile);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbxDB_Name);
            this.Controls.Add(this.tbxInstance);
            this.Controls.Add(this.combxDBPlatform);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateEneDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地理数据库创建";
            ((System.ComponentModel.ISupportInitialize)(this.combxDBPlatform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxInstance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDB_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_DB_pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_DB_admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_GDB_pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_GDB_admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxEcpFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit combxDBPlatform;
        private DevExpress.XtraEditors.TextEdit tbxInstance;
        private DevExpress.XtraEditors.TextEdit tbxDB_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tbox_DB_pwd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbox_DB_admin;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit tbox_GDB_pwd;
        private DevExpress.XtraEditors.TextEdit tbox_GDB_admin;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tboxEcpFile;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_FileBrowser;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
    }
}