using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Util
{
    public class Select2GroupObject
    {
        public Select2GroupObject() { }
        public Select2GroupObject(string id, string text)
        {
            this.id = id;
            this.text = text;
        }
        public Select2GroupObject(string id, string text, string icon)
        {
            this.id = id;
            this.text = text;
            this.icon = icon;
        }
        public Select2GroupObject(string id, string text, string icon, string data)
        {
            this.id = id;
            this.text = text;
            this.icon = icon;
            this.data = data;
        }
        public string id { get; set; }
        public string text { get; set; }
        public string icon { get; set; }
        public string data { get; set; }

        public List<Select2ResultObject> children { get; set; }
    }
}
