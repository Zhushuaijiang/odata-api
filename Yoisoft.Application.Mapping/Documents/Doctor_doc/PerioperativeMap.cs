﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient;

namespace Yoisoft.Application.Mapping
{
   public class PerioperativeMap : EntityTypeConfiguration<PerioperativeEntity>
    {
        public PerioperativeMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_DOCTORS_PERIOPERATIVE");
            //主键
            this.HasKey(t => t.ID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
