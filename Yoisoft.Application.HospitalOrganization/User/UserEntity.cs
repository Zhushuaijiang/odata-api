using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.HospitalOrganization.User
{

    public class UserEntity: IBaseEntity
    {
        /// <summary> 用户ID </summary>
        [Key]
        [Column("USERID")]
        public string USERID { get; set; }
        /// <summary> 用户姓名 </summary>
        [Column("USNAME")]
        public string USNAME { get; set; }
        /// <summary> 用户姓名汉语拼音 </summary>
        [Column("NAME_PHONETIC")]
        public string NAME_PHONETIC { get; set; }
        /// <summary> 用户登录密码 </summary>
        [Column("PASSWORD")]
        public string PASSWORD { get; set; }
        /// <summary> 签名密码 </summary>
        [Column("SIGN_PASSWORD")]
        public string SIGN_PASSWORD { get; set; }
        /// <summary> 病区代码 </summary>
        [Column("WARDCODE")]
        public int? WARDCODE { get; set; }
        /// <summary> 科室代码 </summary>
        [Column("DEPTCODE")]
        public int? DEPTCODE { get; set; }
        /// <summary> 职位ID </summary>
        [Column("POSTID")]
        public int POSTID { get; set; }
        /// <summary> 职称ID </summary>
        [Column("TITLEID")]
        public int TITLEID { get; set; }
        /// <summary> 职位级别 </summary>
        [Column("POST_LEVEL")]
        public int? POST_LEVEL { get; set; }
        /// <summary> 医疗组 </summary>
        [Column("MEDICAL_GROUP")]
        public int? MEDICAL_GROUP { get; set; }
        /// <summary> 注册号 </summary>
        [Column("USERNO")]
        public string USERNO { get; set; }
        /// <summary> 状态 </summary>
        [Column("STATE")]
        public int STATE { get; set; }
        /// <summary> 系统工作站ID </summary>
        [Column("BASICROLE")]
        public int BASICROLE { get; set; }
        /// <summary> 注册时间 </summary>
        [Column("REGISTDATE")]
        public DateTime REGISTDATE { get; set; }
        /// <summary> 上级医师 </summary>
        [Column("SUPERIOR_DOCTORS")]
        public string SUPERIOR_DOCTORS { get; set; }
        /// <summary> 上级护士 </summary>
        [Column("SUPERIOR_NURSE")]
        public string SUPERIOR_NURSE { get; set; }
        /// <summary> 机构ID </summary>
        [Column("ORGANID")]
        public string ORGANID { get; set; }
        /// <summary> HIS用户ID </summary>
        [Column("HIS_USID")]
        public string HIS_USID { get; set; }
        /// <summary> 用户组ID </summary>
        [Column("USER_GROUP_ID")]
        public int? USER_GROUP_ID { get; set; }
        /// <summary> 用户组名称 </summary>
        [Column("USER_GROUP_NAME")]
        public string USER_GROUP_NAME { get; set; }
        [Column("DELETEMARK")]
        public int DELETEMARK { get; set; }
        //[NotMapped]
        //public string LOGINMSG { get; set; }
        //[NotMapped]
        //public bool LOGINOK { get; set; }

        //public void Create()
        //{
        //    this.DELETEMARK = 0;
        //    this.REGISTDATE = DateTime.Now; 
        //}
        //public void Modify(string keyvalue)
        //{

        //}

    }
}
