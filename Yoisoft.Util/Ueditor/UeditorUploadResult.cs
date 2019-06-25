using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Util.Ueditor
{
    /// <summary>
    /// 版 本 Yiosoft V1.0.0 佑医敏捷开发框架
    /// Copyright (c) 2018-2050 杭州佑医科技有限公司
    /// 创建人：佑医-框架开发组
    /// 日 期：2019.02.20
    /// 描 述：百度编辑器UE上传返回结果
    /// </summary>
    public class UeditorUploadResult
    {
        public UeditorUploadState State { get; set; }
        public string Url { get; set; }
        public string OriginFileName { get; set; }

        public string ErrorMessage { get; set; }
    }

    public enum UeditorUploadState
    {
        Success = 0,
        SizeLimitExceed = -1,
        TypeNotAllow = -2,
        FileAccessError = -3,
        NetworkError = -4,
        Unknown = 1,
    }
}
