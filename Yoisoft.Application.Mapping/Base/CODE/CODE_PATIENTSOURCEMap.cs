﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{
    
    public class CODE_PATIENTSOURCEMap : EntityTypeConfiguration<CODE_PATIENTSOURCEEntity>
    {
        public CODE_PATIENTSOURCEMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_CODE_PATIENTSOURCE");
            //主键
            this.HasKey(t => t.PATIENTSOURCEID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
