using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Util
{
    public class PackageResultEntity<T>
    {
        public string msg { get; set; }

        public IEnumerable<T> list { get; set; }
    }
}
