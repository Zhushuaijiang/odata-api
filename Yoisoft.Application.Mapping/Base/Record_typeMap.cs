using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{
   public class Record_typeMap: EntityTypeConfiguration<Record_typeEntity>
    {
        public Record_typeMap()
        {
            #region 表、主键
            //表
            this.ToTable("T_XT_ITEM");
            //主键
            this.HasKey(t => t.ITEMID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
