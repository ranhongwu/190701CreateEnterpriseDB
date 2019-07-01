using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CreateConnectEnterpriseDB;

namespace CreateCollectEnterpriseDB
{
    public partial class FrmCreateEneDB : DevExpress.XtraEditors.XtraForm
    {
        public FrmCreateEneDB()
        {
            InitializeComponent();
        }

        #region 变量定义
        private string DB_platform;
        private string instance;
        private string DB_Name;
        private string DB_admin;
        private string DB_pwd;
        private string GDB_admin;
        private string GDB_pwd;
        private string auth_path;
        #endregion

        private void btn_FileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //许可文件见Resource文件夹
            openFile.Filter = "许可文件(*.ecp)|*.ecp";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                tboxEcpFile.Text = openFile.FileName;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //检验是否所有参数都不为空
            if (DB_platform == null || instance == null || DB_Name == null || DB_admin == null
                || DB_pwd == null || GDB_admin == null || GDB_pwd == null || auth_path == null)
                return;
            EnterpriseDB enterpriseDB = new EnterpriseDB();
            this.tbox_DB_admin_EditValueChanged(null, null);
            this.tbox_GDB_admin_EditValueChanged(null, null);
            //判断数据库命名是否符合规范
            if(char.IsNumber(DB_Name.First())|| System.Text.RegularExpressions.Regex.IsMatch(DB_Name,"[A-Z]"))
            {
                MessageBox.Show(null, "数据库命名错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                enterpriseDB.CreateEnterpriseDB(DB_platform, instance, DB_Name, DB_admin, DB_pwd, GDB_admin,
                    GDB_pwd, auth_path);
            }
            catch
            {
                MessageBox.Show(null,"数据库创建失败","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("数据库创建成功");
        }

        private void combxDBPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB_platform = combxDBPlatform.Text;
        }

        private void tbxInstance_EditValueChanged(object sender, EventArgs e)
        {
            instance = tbxInstance.Text;
        }

        private void tbox_DB_admin_EditValueChanged(object sender, EventArgs e)
        {
            DB_admin = tbox_DB_admin.Text;
        }

        private void tbxDB_Name_EditValueChanged(object sender, EventArgs e)
        {
            DB_Name = tbxDB_Name.Text;
        }

        private void tbox_DB_pwd_EditValueChanged(object sender, EventArgs e)
        {
            DB_pwd = tbox_DB_pwd.Text;
        }

        private void tbox_GDB_admin_EditValueChanged(object sender, EventArgs e)
        {
            GDB_admin = tbox_GDB_admin.Text;
        }

        private void tbox_GDB_pwd_EditValueChanged(object sender, EventArgs e)
        {
            GDB_pwd = tbox_GDB_pwd.Text;
        }

        private void tboxEcpFile_EditValueChanged(object sender, EventArgs e)
        {
            auth_path = tboxEcpFile.Text;
        }
    }
}