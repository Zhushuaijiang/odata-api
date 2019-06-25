using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Patient
{
    public class DoctorsOperationEntity:IBaseEntity
    {
        /// <summary> 手术ID </summary>
        [Column("ID")]
        [Key]
        public string ID { get; set; }
        /// <summary> 病人序号 </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 手术开始时间 </summary>
        [Column("STARTTIME")]
        public DateTime? STARTTIME { get; set; }
        /// <summary> 手术结束时间 </summary>
        [Column("ENDTIME")]
        public DateTime? ENDTIME { get; set; }
        /// <summary> 术前诊断代码 </summary>
        [Column("PREOPERATIVE_DIAGNOSIS_CODE")]
        public string PREOPERATIVE_DIAGNOSIS_CODE { get; set; }
        /// <summary> 术前诊断名称 </summary>
        [Column("PREOPERATIVE_DIAGNOSIS_NAME")]
        public string PREOPERATIVE_DIAGNOSIS_NAME { get; set; }
        /// <summary> 手术代码 </summary>
        [Column("OPERATION_CODE")]
        public string OPERATION_CODE { get; set; }
        /// <summary> 手术名称 </summary>
        [Column("OPERATION_NAME")]
        public string OPERATION_NAME { get; set; }
        /// <summary> 主刀医师ID </summary>
        [Column("CHIEF_DOCTORID")]
        public string CHIEF_DOCTORID { get; set; }
        /// <summary> 主刀医师姓名 </summary>
        [Column("CHIEF_DOCTORNAME")]
        public string CHIEF_DOCTORNAME { get; set; }
        /// <summary> 一助人员ID </summary>
        [Column("FIRST_ASSISTANTID")]
        public string FIRST_ASSISTANTID { get; set; }
        /// <summary> 一助人员姓名 </summary>
        [Column("FIRST_ASSISTANTNAME")]
        public string FIRST_ASSISTANTNAME { get; set; }
        /// <summary> 二助人员ID </summary>
        [Column("SECOND_ASSISTANTID")]
        public string SECOND_ASSISTANTID { get; set; }
        /// <summary> 二助人员姓名 </summary>
        [Column("SECOND_ASSISTANTNAME")]
        public string SECOND_ASSISTANTNAME { get; set; }
        /// <summary> 麻醉方式 </summary>
        [Column("ANESTHESIA_MANNER")]
        public string ANESTHESIA_MANNER { get; set; }
        /// <summary> 麻醉人员ID </summary>
        [Column("ANESTHESIA_PERSONID")]
        public string ANESTHESIA_PERSONID { get; set; }
        /// <summary> 麻醉人员姓名 </summary>
        [Column("ANESTHESIA_PERSONNAME")]
        public string ANESTHESIA_PERSONNAME { get; set; }
        /// <summary> 手术经过 </summary>
        [Column("OPERATION_PROCESS")]
        public string OPERATION_PROCESS { get; set; }
        /// <summary> 书写医师ID </summary>
        [Column("WRITING_DOCTORS_ID")]
        public string WRITING_DOCTORS_ID { get; set; }
        /// <summary> 书写医师姓名 </summary>
        [Column("WRITING_DOCTORS_NAME")]
        public string WRITING_DOCTORS_NAME { get; set; }
        /// <summary> 记录时间 </summary>
        [Column("RECORDTIME")]
        public DateTime? RECORDTIME { get; set; }
        /// <summary> 书写时间 </summary>
        [Column("WRITINGTIME")]
        public DateTime? WRITINGTIME { get; set; }
        /// <summary> 围手术期文书ID </summary>
        [Column("SURGERYID")]
        public string SURGERYID { get; set; }
        /// <summary> 麻醉方式其他 </summary>
        [Column("ANESTHESIA_OTHER")]
        public string ANESTHESIA_OTHER { get; set; }
        /// <summary> 手术状态 0.暂存 1.保存 </summary>
        [Column("STATE")]
        public int? STATE { get; set; }
        /// <summary> 手术级别 </summary>
        [Column("OPERATION_GRADE")]
        public string OPERATION_GRADE { get; set; }
        /// <summary> 手术补充 </summary>
        [Column("OPERATION_SUPPLEMENT")]
        public string OPERATION_SUPPLEMENT { get; set; }
        /// <summary> 外院标志 </summary>
        [Column("OUTSIDE_SIGN")]
        public string OUTSIDE_SIGN { get; set; }
        /// <summary> 患者代理人与患者关系 </summary>
        [Column("AGENT_RELATIONSHIP")]
        public string AGENT_RELATIONSHIP { get; set; }
        /// <summary> 患者代理人与患者关系其他 </summary>
        [Column("AGENT_RELATIONSHIP_OTHER")]
        public string AGENT_RELATIONSHIP_OTHER { get; set; }
        /// <summary> 输血护士ID </summary>
        [Column("TRANSBLOOD_NURSEID")]
        public string TRANSBLOOD_NURSEID { get; set; }
        /// <summary> 输血护士姓名 </summary>
        [Column("TRANSBLOOD_NURSENAME")]
        public string TRANSBLOOD_NURSENAME { get; set; }
        /// <summary> 手术部位 </summary>
        [Column("SURGICAL_SITE")]
        public string SURGICAL_SITE { get; set; }
        /// <summary> 手术部位其他 </summary>
        [Column("SURGICAL_SITE_OTHER")]
        public string SURGICAL_SITE_OTHER { get; set; }
        /// <summary> 输血反应 </summary>
        [Column("TRANSBLOOD_REACTION")]
        public string TRANSBLOOD_REACTION { get; set; }
        /// <summary> 输血反应其他 </summary>
        [Column("TRANSBLOOD_REACTION_OTHER")]
        public string TRANSBLOOD_REACTION_OTHER { get; set; }
        /// <summary> 手术类型 </summary>
        [Column("SURGERYTYPE")]
        public string SURGERYTYPE { get; set; }
        /// <summary> 麻醉满意程度 </summary>
        [Column("ANESTHESIA_SATISFACTION")]
        public string ANESTHESIA_SATISFACTION { get; set; }
        /// <summary> 总入量 </summary>
        [Column("TOTALINPUT")]
        public string TOTALINPUT { get; set; }
        /// <summary> 总出量 </summary>
        [Column("TOTALOUTPUT")]
        public string TOTALOUTPUT { get; set; }
        /// <summary> 失血量 </summary>
        [Column("BLOODLOSS")]
        public string BLOODLOSS { get; set; }
        /// <summary> 输血量 </summary>
        [Column("BLOODTRANSFUSION")]
        public string BLOODTRANSFUSION { get; set; }
        /// <summary> 麻醉开始时间 </summary>
        [Column("ANESTHESIA_STARTTIME")]
        public DateTime? ANESTHESIA_STARTTIME { get; set; }
        /// <summary> 出室时间 </summary>
        [Column("EXITTIME")]
        public DateTime? EXITTIME { get; set; }
        /// <summary> 手术间编号 </summary>
        [Column("ROOMNUMBER")]
        public string ROOMNUMBER { get; set; }
        /// <summary> 介入物 </summary>
        [Column("INTERVENTION")]
        public string INTERVENTION { get; set; }
        /// <summary> 皮肤消毒描述 </summary>
        [Column("SKINDESCRIPTION")]
        public string SKINDESCRIPTION { get; set; }
        /// <summary> 术前用药 </summary>
        [Column("PREMEDICATION")]
        public string PREMEDICATION { get; set; }
        /// <summary> 术中用药 </summary>
        [Column("INTRAOPERATIVE")]
        public string INTRAOPERATIVE { get; set; }
        /// <summary> 引流标志 </summary>
        [Column("DRAINAGESIGN")]
        public string DRAINAGESIGN { get; set; }
        /// <summary> 引流材料名称 </summary>
        [Column("DRAINAGE_MATERIAL_NAME")]
        public string DRAINAGE_MATERIAL_NAME { get; set; }
        /// <summary> 引流材料数目 </summary>
        [Column("DRAINAGE_MATERIAL_NUMBER")]
        public string DRAINAGE_MATERIAL_NUMBER { get; set; }
        /// <summary> 放置部位 </summary>
        [Column("PLACEMENT")]
        public string PLACEMENT { get; set; }
        /// <summary> 手术体位 </summary>
        [Column("SURGICAL_POSITION")]
        public string SURGICAL_POSITION { get; set; }
        /// <summary> 手术标志 1有，2无 </summary>
        [Column("SURGICALSIGN")]
        public int? SURGICALSIGN { get; set; }
        /// <summary> 手术来源 1.操作 </summary>
        [Column("SOURCESURGERY")]
        public int? SOURCESURGERY { get; set; }
    }
}
