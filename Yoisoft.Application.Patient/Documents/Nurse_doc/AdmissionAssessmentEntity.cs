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
    public class AdmissionAssessmentEntity:IBaseEntity
    {
        /// <summary> 唯一ID </summary>
         [Key]
         [Column("ID")]
        public string ID { get; set; }
        /// <summary> 病人序号 </summary>
        [Column("PATIENTID")]
        public string PATIENTID { get; set; }
        /// <summary> 入院方式 </summary>
        [Column("ADMISSION_METHOD")]
        public string ADMISSION_METHOD { get; set; }
        /// <summary>  卫生处置 </summary>
        [Column("SANITARY_DISPOSAL")]
        public string SANITARY_DISPOSAL { get; set; }
        /// <summary> 简要病情 </summary>
        [Column("BRIEF_ILLNESS")]
        public string BRIEF_ILLNESS { get; set; }
        /// <summary> 体温 </summary>
        [Column("TEMPERATURE")]
        public string TEMPERATURE { get; set; }
        /// <summary> 脉搏 </summary>
        [Column("PULSE")]
        public string PULSE { get; set; }
        /// <summary> 呼吸 </summary>
        [Column("BREATHING")]
        public string BREATHING { get; set; }
        /// <summary> 血压1 blood pressure  </summary>
        [Column("BP1")]
        public string BP1 { get; set; }
        /// <summary> 意识 </summary>
        [Column("CONSCIOUSNESS")]
        public string CONSCIOUSNESS { get; set; }
        /// <summary> 表情 </summary>
        [Column("EXPRESSION")]
        public string EXPRESSION { get; set; }
        /// <summary> 面色 </summary>
        [Column("FACE_COLOR")]
        public string FACE_COLOR { get; set; }
        /// <summary> 面色其他 </summary>
        [Column("OTHER_FACE_COLOR")]
        public string OTHER_FACE_COLOR { get; set; }
        /// <summary> 身高 </summary>
        [Column("HEIGHT")]
        public string HEIGHT { get; set; }
        /// <summary> 体重 </summary>
        [Column("WEIGHT")]
        public string WEIGHT { get; set; }
        /// <summary> 过去三个月体重有无减轻 </summary>
        [Column("LOSE_WEIGHT")]
        public string LOSE_WEIGHT { get; set; }
        /// <summary> 过去三个月体重有无减轻重量 </summary>
        [Column("WEIGHT_LOSS_WEIGHT")]
        public string WEIGHT_LOSS_WEIGHT { get; set; }
        /// <summary> 体形 </summary>
        [Column("FIGURE")]
        public string FIGURE { get; set; }
        /// <summary> 体形其他 </summary>
        [Column("OTHER_FIGURE")]
        public string OTHER_FIGURE { get; set; }
        /// <summary> 皮肤 </summary>
        [Column("SKIN")]
        public string SKIN { get; set; }
        /// <summary> 皮肤褥疮部位 </summary>
        [Column("SKIN_BEDSORE_SITE")]
        public string SKIN_BEDSORE_SITE { get; set; }
        /// <summary> 皮肤褥疮大小 </summary>
        [Column("SKIN_BEDSORE_SIZE")]
        public string SKIN_BEDSORE_SIZE { get; set; }
        /// <summary> 皮肤饱满度 </summary>
        [Column("SKIN_PLUMPNESS")]
        public string SKIN_PLUMPNESS { get; set; }
        /// <summary> 皮肤水肿部位  </summary>
        [Column("EDEMA_SITE")]
        public string EDEMA_SITE { get; set; }
        /// <summary> 皮肤水肿程度 </summary>
        [Column("DEGREE_OF_EDEMA")]
        public string DEGREE_OF_EDEMA { get; set; }
        /// <summary> 口腔粘膜 </summary>
        [Column("ORAL_MUCOSA")]
        public string ORAL_MUCOSA { get; set; }
        /// <summary> 口腔粘膜其他 </summary>
        [Column("OTHER_ORAL_MUCOSA")]
        public string OTHER_ORAL_MUCOSA { get; set; }
        /// <summary> 假牙 </summary>
        [Column("FALSE_TEETH")]
        public string FALSE_TEETH { get; set; }
        /// <summary> 食欲 </summary>
        [Column("APPETITE")]
        public string APPETITE { get; set; }
        /// <summary> 饮食 </summary>
        [Column("DIET")]
        public string DIET { get; set; }
        /// <summary> 排尿 </summary>
        [Column("MICTURITION")]
        public string MICTURITION { get; set; }
        /// <summary> 尿色 </summary>
        [Column("URINE_COLOR")]
        public string URINE_COLOR { get; set; }
        /// <summary> 排便 </summary>
        [Column("DEFECATION")]
        public string DEFECATION { get; set; }
        /// <summary> 腹泻次数   </summary>
        [Column("TIMES_OF_DIARRHOEA")]
        public string TIMES_OF_DIARRHOEA { get; set; }
        /// <summary> 大便颜色 </summary>
        [Column("STOOL_COLOR")]
        public string STOOL_COLOR { get; set; }
        /// <summary> 活动 </summary>
        [Column("ACTIVITY")]
        public string ACTIVITY { get; set; }
        /// <summary> 自理能力 </summary>
        [Column("SELF_CARE_ABILITY")]
        public string SELF_CARE_ABILITY { get; set; }
        /// <summary> 自理能力穿衣 </summary>
        [Column("SELF_CARE_ABILITY_DRESSING")]
        public string SELF_CARE_ABILITY_DRESSING { get; set; }
        /// <summary> 睡眠 </summary>
        [Column("SLEEP")]
        public string SLEEP { get; set; }
        /// <summary> 睡眠药剂名称    </summary>
        [Column("NAME_OF_SLEEPING_AGENT")]
        public string NAME_OF_SLEEPING_AGENT { get; set; }
        /// <summary> 睡眠药剂量 </summary>
        [Column("SLEEPING_DOSE")]
        public string SLEEPING_DOSE { get; set; }
        /// <summary> 感觉视力 </summary>
        [Column("OTHER")]
        public string OTHER { get; set; }
        /// <summary> 感觉视力其他 </summary>
        [Column("OTHER_OTHER")]
        public string OTHER_OTHER { get; set; }
        /// <summary> 感觉听力 </summary>
        [Column("HEARING")]
        public string HEARING { get; set; }
        /// <summary> 感觉听力其他 </summary>
        [Column("OTHER_HEARING")]
        public string OTHER_HEARING { get; set; }
        /// <summary> 疼痛 </summary>
        [Column("PAIN")]
        public string PAIN { get; set; }
        /// <summary> 疼痛部位 </summary>
        [Column("PART_OF_PAIN")]
        public string PART_OF_PAIN { get; set; }
        /// <summary> 疼痛性质       </summary>
        [Column("PROPERTIES_OF_PAIN")]
        public string PROPERTIES_OF_PAIN { get; set; }
        /// <summary> 疼痛时间 </summary>
        [Column("TIME_OF_PAIN")]
        public string TIME_OF_PAIN { get; set; }
        /// <summary> 疼痛间隔时间  </summary>
        [Column("PAIN_INTERVAL_TIME")]
        public string PAIN_INTERVAL_TIME { get; set; }
        /// <summary> 饮食禁忌   </summary>
        [Column("DIET_TABOO")]
        public string DIET_TABOO { get; set; }
        /// <summary> 饮食偏好   </summary>
        [Column("DIET_PREFERENCE")]
        public string DIET_PREFERENCE { get; set; }
        /// <summary> 吸烟  </summary>
        [Column("SMOKE")]
        public string SMOKE { get; set; }
        /// <summary> 吸烟数量  </summary>
        [Column("NUMBER_OF_SMOKING")]
        public string NUMBER_OF_SMOKING { get; set; }
        /// <summary> 已吸多少年 吸烟时间 </summary>
        [Column("SMOKING_TIME")]
        public string SMOKING_TIME { get; set; }
        /// <summary> 已戒多少年   </summary>
        [Column("TIME_FOR_SMOKING_CESSATION")]
        public string TIME_FOR_SMOKING_CESSATION { get; set; }
        /// <summary> 饮酒 </summary>
        [Column("DRINK_WINE")]
        public string DRINK_WINE { get; set; }
        /// <summary> 饮酒量  </summary>
        [Column("ALCOHOL_CONSUMPTION")]
        public string ALCOHOL_CONSUMPTION { get; set; }
        /// <summary> 饮酒名称  </summary>
        [Column("NAME_OF_DRINKING")]
        public string NAME_OF_DRINKING { get; set; }
        /// <summary> 饮酒已戒时间    </summary>
        [Column("ABSTINENCE_TIME")]
        public string ABSTINENCE_TIME { get; set; }
        /// <summary> 吸毒 </summary>
        [Column("DRUG")]
        public string DRUG { get; set; }
        /// <summary> 吸毒名称  </summary>
        [Column("DRUG_NAME")]
        public string DRUG_NAME { get; set; }
        /// <summary> 吸毒量  </summary>
        [Column("DRUG_USE")]
        public string DRUG_USE { get; set; }
        /// <summary> 吸毒时间    </summary>
        [Column("DRUG_TIME")]
        public string DRUG_TIME { get; set; }
        /// <summary> 吸毒已戒多少年   </summary>
        [Column("TIME_FOR_DRUG_ABSTINENCE")]
        public string TIME_FOR_DRUG_ABSTINENCE { get; set; }
        /// <summary> 过敏史 </summary>
        [Column("ANAPHYLAXIS")]
        public string ANAPHYLAXIS { get; set; }
        /// <summary> 过敏史名称 </summary>
        [Column("NAME_OF_ALLERGY_HISTORY")]
        public string NAME_OF_ALLERGY_HISTORY { get; set; }
        /// <summary> 过敏史反应 </summary>
        [Column("ALLERGY_HISTORY_REACTION")]
        public string ALLERGY_HISTORY_REACTION { get; set; }
        /// <summary> 曾患疾病   </summary>
        [Column("HAVE_DISEASE")]
        public string HAVE_DISEASE { get; set; }
        /// <summary> 曾做过手术   </summary>
        [Column("HAD_SURGERY_BEFORE")]
        public string HAD_SURGERY_BEFORE { get; set; }
        /// <summary> 家庭史  </summary>
        [Column("FAMILY_HISTORY")]
        public string FAMILY_HISTORY { get; set; }
        /// <summary> 沟通方式 </summary>
        [Column("COMMUNICATIO_MODE")]
        public string COMMUNICATIO_MODE { get; set; }
        /// <summary> 表达与理解能力 </summary>
        [Column("EXPRESSION_AND_COMPREHENSION")]
        public string EXPRESSION_AND_COMPREHENSION { get; set; }
        /// <summary> 与人交流 </summary>
        [Column("COMMUNICATE_WITH_PEOPLE")]
        public string COMMUNICATE_WITH_PEOPLE { get; set; }
        /// <summary> 对疾病认识 </summary>
        [Column("KNOWLEDGE_OF_DISEASE")]
        public string KNOWLEDGE_OF_DISEASE { get; set; }
        /// <summary> 自诉 </summary>
        [Column("PRIVATE_PROSECUTION")]
        public string PRIVATE_PROSECUTION { get; set; }
        /// <summary> 住院顾虑   </summary>
        [Column("INPATIENT_CONCERNS")]
        public string INPATIENT_CONCERNS { get; set; }
        /// <summary> 住院顾虑其他 </summary>
        [Column("OTHER_INPATIENT_CONCERNS")]
        public string OTHER_INPATIENT_CONCERNS { get; set; }
        /// <summary> 近期个人重大事件 </summary>
        [Column("RECENT_PERSONAL_EVENTS")]
        public string RECENT_PERSONAL_EVENTS { get; set; }
        /// <summary> 近期个人重大事件其他 </summary>
        [Column("OTHER_RECENT_PERSONAL_EVENTS")]
        public string OTHER_RECENT_PERSONAL_EVENTS { get; set; }
        /// <summary> 家庭态度 </summary>
        [Column("FAMILY_ATTITUDE")]
        public string FAMILY_ATTITUDE { get; set; }
        /// <summary> 医疗费用   </summary>
        [Column("MEDICAL_EXPENSE")]
        public string MEDICAL_EXPENSE { get; set; }
        /// <summary> 家庭成员 </summary>
        [Column("MEMBER_OF_FAMILY")]
        public string MEMBER_OF_FAMILY { get; set; }
        /// <summary> 入院介绍    </summary>
        [Column("ADMISSION_HOSPITAL")]
        public string ADMISSION_HOSPITAL { get; set; }
        /// <summary> 资料来源 </summary>
        [Column("SOURCE_INFORMATION")]
        public string SOURCE_INFORMATION { get; set; }
        /// <summary> 资料来源其他 </summary>
        [Column("OTHER_SOURCE_INFORMATION")]
        public string OTHER_SOURCE_INFORMATION { get; set; }
        /// <summary> 记录护士 </summary>
        [Column("RECORD_NURSE")]
        public string RECORD_NURSE { get; set; }
        /// <summary> 记录时间 </summary>
        [Column("RECORDING_TIME")]
        public string RECORDING_TIME { get; set; }
        /// <summary> 实际记录时间 </summary>
        [Column("ACTUAL_RECORDING_TIME")]
        public string ACTUAL_RECORDING_TIME { get; set; }
        /// <summary> 上级护士签名   </summary>
        [Column("SIGNATURE_SUPERIOR_NURSE")]
        public string SIGNATURE_SUPERIOR_NURSE { get; set; }
        /// <summary> 保存类型 </summary>
        [Column("SAVE_TYPE")]
        public string SAVE_TYPE { get; set; }
        /// <summary> 压疮评分 </summary>
        [Column("PRESSURE_ULCER_SCORE")]
        public string PRESSURE_ULCER_SCORE { get; set; }
        /// <summary> 排便次数增多 </summary>
        [Column("INCREASED_FREQUENCY_DEFECATION")]
        public string INCREASED_FREQUENCY_DEFECATION { get; set; }
        /// <summary> 排便其他  </summary>
        [Column("OTHER_DEFECATION")]
        public string OTHER_DEFECATION { get; set; }
        /// <summary> 大便颜色其他  </summary>
        [Column("OTHER_STOOL_COLOR")]
        public string OTHER_STOOL_COLOR { get; set; }
        /// <summary> 其他感觉 </summary>
        [Column("OTHER_FEELINGS")]
        public string OTHER_FEELINGS { get; set; }
        /// <summary> 过敏史过敏食物 </summary>
        [Column("ALLERGIC_FOOD")]
        public string ALLERGIC_FOOD { get; set; }
        /// <summary> 过敏史方面 </summary>
        [Column("ALLERGY_HISTORY")]
        public string ALLERGY_HISTORY { get; set; }
        /// <summary> 跌倒评分 </summary>
        [Column("FALL_SCORE")]
        public string FALL_SCORE { get; set; }
        /// <summary> 卫生处置_其他 </summary>
        [Column("SANITARY_DISPOSAL_OTHER")]
        public string SANITARY_DISPOSAL_OTHER { get; set; }
        /// <summary> 主治医师 </summary>
        [Column("ATTENDING_DOCTOR")]
        public string ATTENDING_DOCTOR { get; set; }
        /// <summary> 血压2 blood pressure  </summary>
        [Column("BP2")]
        public string BP2 { get; set; }
        /// <summary> 表情其他 </summary>
        [Column("EXPRESSION_OTHER")]
        public string EXPRESSION_OTHER { get; set; }
        /// <summary> 饮食其他 </summary>
        [Column("DIET_OTHER")]
        public string DIET_OTHER { get; set; }
        /// <summary> 排尿其他 </summary>
        [Column("MICTURITION_OTHER")]
        public string MICTURITION_OTHER { get; set; }
        /// <summary> 尿色其他 </summary>
        [Column("URINE_COLOR_OTHER")]
        public string URINE_COLOR_OTHER { get; set; }
        /// <summary> 活动其他 </summary>
        [Column("ACTIVITY_OTHER")]
        public string ACTIVITY_OTHER { get; set; }
        /// <summary> 活动_偏瘫 </summary>
        [Column("ACTIVITY_HEMIPLEGIA")]
        public string ACTIVITY_HEMIPLEGIA { get; set; }
        /// <summary> 活动_截瘫_高低 </summary>
        [Column("ACTIVITY_PARAPLEGIA")]
        public string ACTIVITY_PARAPLEGIA { get; set; }
        /// <summary> 活动_截瘫_部位 </summary>
        [Column("ACTIVITY_PARAPLEGIA_POSITION")]
        public string ACTIVITY_PARAPLEGIA_POSITION { get; set; }
        /// <summary> 自理能力_帮助 </summary>
        [Column("SELF_CARE_ABILITY_HELP")]
        public string SELF_CARE_ABILITY_HELP { get; set; }
        /// <summary> 沟通方式_其他 </summary>
        [Column("COMMUNICATIO_MODE_OTHER")]
        public string COMMUNICATIO_MODE_OTHER { get; set; }
        /// <summary> 住院顾虑_有无 </summary>
        [Column("INPATIENT_CONCERNS_HAVE")]
        public string INPATIENT_CONCERNS_HAVE { get; set; }
    }
}
