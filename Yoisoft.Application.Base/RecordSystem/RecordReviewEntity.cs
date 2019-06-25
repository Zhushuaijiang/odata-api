using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoisoft.Util;

namespace Yoisoft.Application.Base
{
    public class RecordReviewEntity:IBaseEntity
    {
        [Column("ID")]
        [Key]
        public int ID { get; set; }

        [Column("PID")]
        public int PID { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("TYPE")]
        public int Type { get; set; }

        [Column("URL")]
        public string Url { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("ICON")]
        public string Icon { get; set; }

        [Column("XH")]
        public int XH { get; set; }
        [Column("CATEGORY")]
        public string CATEGORY { get; set; }

    }
}
