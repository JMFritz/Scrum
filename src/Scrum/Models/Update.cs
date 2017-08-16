using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Scrum.Models
{
    [Table("Updates")]
    public class Update
    {
        [Key]
        public int UpdateId { get; set; }
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }
        public DateTime TimeStamp { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Project Project { get; set; }
    }
}
