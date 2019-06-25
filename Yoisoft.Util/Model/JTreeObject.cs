using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Util
{
    public class JTreeObject
    {
        public JTreeObject() { }
        public JTreeObject(string id, string text, string icon, int rc, string type, string data)
        {
            this.id = id;
            this.text = text;
            if (string.IsNullOrEmpty(icon)) this.icon = false; else this.icon = icon;
            this.rc = rc;
            children = rc == 0 ? false : true;
            this.type = type;
            this.data = data;
        }
        public JTreeObject(string id, string text, string icon, List<JTreeObject> children, string type, string data)
        {
            this.id = id;
            this.text = text;
            if (string.IsNullOrEmpty(icon)) this.icon = false; else this.icon = icon;
            this.rc = null;
            this.children = children;
            this.type = type;
            this.data = data;
        }
        public string id { get; set; }
        public string text { get; set; }
        public object icon { get; set; }
        public object children { get; set; }
        public string type { get; set; }
        public string data { get; set; }
        public int? rc { get; set; }
    }
}
