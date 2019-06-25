using System.Collections.Generic;

namespace Yoisoft.Util
{
    public class TableObject
    {

        public TableObject() { }
        public TableObject(IEnumerable<string[]> data, int draw, long recordsTotal, long recordsFiltered)
        {
            this.data = data;
            this.draw = draw;
            this.recordsTotal = recordsTotal;
            this.recordsFiltered = recordsFiltered;
        }
        public IEnumerable<string[]> data { get; set; }

        public int draw { get; set; }
        public long recordsTotal { get; set; }
        public long recordsFiltered { get; set; }
    }
}