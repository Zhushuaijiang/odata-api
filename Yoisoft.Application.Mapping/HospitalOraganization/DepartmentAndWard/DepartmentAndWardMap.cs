using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.HospitalOrganization.DepartmentAndWard;

namespace Yoisoft.Application.Mapping
{
    class DepartmentAndWardMap : EntityTypeConfiguration<DeptAndWardEntity>
    {
        public DepartmentAndWardMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_CODE_DEPT_WARD");
            //主键
            this.HasKey(t => t.ID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
