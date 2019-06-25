using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Util
{
    public class ResultObject
    {
        public ResultObject(bool succ)
        {
            this.succ = succ;
        }

        public ResultObject(bool succ, List<JTreeObject> d)
        {
            this.succ = succ;
            this.d = d;
        }
        public ResultObject(bool succ, object msg)
        {
            this.succ = succ;
            this.msg = msg;
        }
        public bool succ { get; set; }
        public object msg { get; set; }
        /// <summary> jstree 专用</summary>
        public List<JTreeObject> d { get; set; }
    }
}
