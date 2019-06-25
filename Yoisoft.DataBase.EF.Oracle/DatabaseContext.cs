using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
namespace Yoisoft.DataBase.Oracle
{
    /// <summary>
    /// 版 本 1.0 佑医敏捷开发框架
    /// Copyright (c) 2018-2050 杭州佑医科技有限公司
    /// 创建人：佑医-框架开发组
    /// 日 期：2019.03.04
    /// 描 述：数据访问(SqlServer) 上下文
    /// </summary>
    public class DatabaseContext : DbContext, IDisposable, IObjectContextAdapter
    {
        #region 构造函数
        /// <summary>
        /// 初始化一个 使用指定数据连接名称或连接串 的数据访问上下文类 的新实例
        /// </summary>
        /// <param name="connString">连接串</param>
        public DatabaseContext(string connString)
            : base(new OracleConnection(connString), true)
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            
        }
        #endregion

        #region 重载
        /// <summary>
        /// 模型创建重载
        /// </summary>
        /// <param name="modelBuilder">模型创建器</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            System.Data.Entity.Database.SetInitializer<DatabaseContext>(null);

            string assembleFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("Yoisoft.DataBase.Oracle.DLL", "Yoisoft.Application.Mapping.DLL").Replace("file:///", "");
            Assembly asm = Assembly.LoadFile(assembleFileName);
            var typesToRegister = asm.GetTypes()
            .Where(type => !String.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            modelBuilder.HasDefaultSchema("YOIEMR");//这里写默认表空间名称
            base.OnModelCreating(modelBuilder);
          
        }
        #endregion
    }
}
