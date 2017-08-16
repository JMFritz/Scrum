using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrum.Models
{
    [Table("ToolTypes")]
    public class ToolType
    {
        [Key]
        public int ToolTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
    }
}
