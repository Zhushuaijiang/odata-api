﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Base;

namespace Yoisoft.Application.Mapping
{

    public class CODE_PROVANDCITYMap : EntityTypeConfiguration<CODE_PROVANDCITYEntity>
    {
        public CODE_PROVANDCITYMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_CODE_PROVANDCITY");
            //主键
            this.HasKey(t => t.ITEM_CODE);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
