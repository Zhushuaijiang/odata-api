using System.Security.Cryptography;
using System.Text;

namespace Yoisoft.Util
{
    /// <summary>
    /// 版 本 Yiosoft V1.0.0 佑医敏捷开发框架
    /// Copyright (c) 2018-2050 杭州佑医科技有限公司
    /// 创建人：佑医-框架开发组
    /// 日 期：2019.02.04
    /// 描 述：数据访问(SqlServer) 上下文
    /// </summary>
    public class Md5Helper
    {
        #region "MD5加密"
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">加密字符</param>
        /// <param name="code">加密位数16/32</param>
        /// <returns></returns>
        public static string Encrypt(string str, int code)
        {
            string strEncrypt = string.Empty;
            if (code == 16)
            {
                strEncrypt = Hash(str).Substring(8, 16);
            }

            if (code == 32)
            {
                strEncrypt = Hash(str);
            }
            return strEncrypt;
        }
        /// <summary>
        /// 32位MD5加密（小写）
        /// </summary>
        /// <param name="input">输入字段</param>
        /// <returns></returns>
        public static string Hash(string input)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        #endregion
    }
}
