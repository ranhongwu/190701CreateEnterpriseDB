using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataManagementTools;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geometry;
using System.Data;
using System.Data.SqlClient;

namespace CreateConnectEnterpriseDB
{
    class EnterpriseDB
    {
        #region 定义变量
        //private static IWorkspaceFactory2 pWorkspaceFactory = new SdeWorkspaceFactoryClass();
        //public static List<IFeatureLayer> pFeaLayers=new List<IFeatureLayer>();//存储矢量数据的图层
        //public static List<IRasterLayer> pRstLayers = new List<IRasterLayer>();//存储栅格数据的图层
        #endregion
        
        #region 数据库的建立
        /// <summary>
        /// 创建企业地理数据库
        /// </summary>
        /// <param name="DB_platform">数据库类型</param>
        /// <param name="instance">地址</param>
        /// <param name="DB_Name">数据库名</param>
        /// <param name="DB_admin">数据库用户名</param>
        /// <param name="DB_pwd">数据库密码</param>
        /// <param name="GDB_admin">地理数据库用户名</param>
        /// <param name="GDB_pwd">地理数据库密码</param>
        /// <param name="auth_path">许可路径</param>
        /// 
        public void CreateEnterpriseDB(string DB_platform,string instance,string DB_name,
            string DB_admin,string DB_pwd, string GDB_admin, string GDB_pwd,string auth_path)
        {
            Geoprocessor gp = new Geoprocessor();
            gp.OverwriteOutput = true;
            CreateEnterpriseGeodatabase ceGDB = new CreateEnterpriseGeodatabase();
            ceGDB.database_platform = DB_platform;
            ceGDB.instance_name =instance;
            ceGDB.database_name = DB_name;
            ceGDB.database_admin =DB_admin;
            ceGDB.database_admin_password = DB_pwd;
            ceGDB.gdb_admin_name = GDB_admin;
            ceGDB.gdb_admin_password = GDB_pwd;
            ceGDB.authorization_file = auth_path;

            gp.Execute(ceGDB, null);
        }
        #endregion
    }
}
