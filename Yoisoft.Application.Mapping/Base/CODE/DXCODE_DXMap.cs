using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{
   
    public class DXCODE_DXMap : EntityTypeConfiguration<DXCODE_DXEntity>
    {
        public DXCODE_DXMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_DXCODE_DX");
            //主键
            this.HasKey(t => t.DXCODE);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
