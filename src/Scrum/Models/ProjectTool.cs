using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Scrum.Models
{
    [Table("ProjectTools")]
    public class ProjectTool
    {
        [Key]
        public int ProjectId { get; set; }
        [Key]
        public int ToolId { get; set; }
        public Project Project { get; set; }
        public Tool Tool { get; set; }
    }
}
