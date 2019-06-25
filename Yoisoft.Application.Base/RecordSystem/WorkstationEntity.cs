using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoisoft.Application.Base
{
    public class WorkstationEntity
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }
        [Column("NAME")]
        public string NAME { get; set; }
        [Column("COLOR")]
        public string COLOR { get; set; }
        [Column("URL")]
        public string URL { get; set; }
        [Column("ICON")]
        public string ICON { get; set; }
        [Column("XH")]
        public long? XH { get; set; }
        [Column("STATE")]
        public long? STATE { get; set; }
        [Column("CONDENSED")]
        public string CONDENSED { get; set; }
    }
}
