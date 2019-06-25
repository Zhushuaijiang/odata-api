using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient;

namespace Yoisoft.Application.Mapping
{
    public class NURSE_RESCUERECORDMap : EntityTypeConfiguration<NURSE_RESCUERECORDEntity>
    {
        public NURSE_RESCUERECORDMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_NURSE_RESCUERECORD");
            //主键
            this.HasKey(t => t.PATIENTID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
