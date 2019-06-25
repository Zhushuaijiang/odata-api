using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.HospitalOrganization.User;

namespace Yoisoft.Application.Mapping
{
    public class UserMap : EntityTypeConfiguration<UserEntity>
    {
        /// <summary>
        /// 病人信息数据库实体映射
        /// </summary>
        public UserMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_SYS_USER");
            //主键
            this.HasKey(t => t.USERID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
