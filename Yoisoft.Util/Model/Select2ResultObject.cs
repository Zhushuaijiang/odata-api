using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Util
{
    public class Select2ResultObject
    {
        public Select2ResultObject()
        {
        }
        public Select2ResultObject(string id, string text)
        {
            this.id = id;
            this.text = text;
        }
        public Select2ResultObject(string id, string text, string title, object data)
        {
            this.id = id;
            this.text = text;
            this.title = title;
            if (data is List<KeyValuePair<string, object>>)
            {
                var settings = new JsonSerializerSettings
                {
                    Converters = new JsonConverter[] { new KeyValuePairConverter() }
                };
                var json = JsonConvert.SerializeObject(data, settings);
                this.data = json;
                return;
            }
            this.data = data;
        }
        public Select2ResultObject(string id, string text, string pid, string ptext, string title, object data)
        {
            this.id = id;
            this.text = text;
            this.pid = pid;
            this.ptext = ptext;
            this.title = title;
            if (data is List<KeyValuePair<string, object>>)
            {
                var settings = new JsonSerializerSettings
                {
                    Converters = new JsonConverter[] { new KeyValuePairConverter() }
                };
                var json = JsonConvert.SerializeObject(data, settings);
                this.data = json;
                return;
            }
            this.data = data;
        }
        public string id { get; set; }
        public string text { get; set; }
        public string icon { get; set; }
        public string pid { get; set; }
        public string ptext { get; set; }
        public string title { get; set; }
        public object data { get; set; }

        public string ToJson()
        {
            var jSetting = new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.None,
                NullValueHandling = NullValueHandling.Ignore
            };
            var json = JsonConvert.SerializeObject(this, jSetting);
            return json;
        }

        public Select2ResultObject FromJObject(JObject jObject)
        {
            return jObject.ToObject<Select2ResultObject>(new JsonSerializer
            {
                DateParseHandling = DateParseHandling.None,
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}
