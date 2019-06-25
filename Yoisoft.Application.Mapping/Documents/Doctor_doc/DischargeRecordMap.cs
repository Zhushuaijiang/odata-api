﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Application.Patient;

namespace Yoisoft.Application.Mapping
{
   public class DischargeRecordMap : EntityTypeConfiguration<DischargeRecordEntity>
    {
        public DischargeRecordMap()
        {
            #region 表、主键
            //表
            this.ToTable("YY_DOCTORS_DISCHARGE_RECORD");
            //主键
            this.HasKey(t => t.PATIENTID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
