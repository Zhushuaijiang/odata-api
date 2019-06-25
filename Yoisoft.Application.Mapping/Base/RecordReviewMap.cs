using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{
    class RecordReviewMap : EntityTypeConfiguration<RecordReviewEntity>
    {
        public RecordReviewMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_XT_RECORDREVIEW");
            //主键
            this.HasKey(t => t.ID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
