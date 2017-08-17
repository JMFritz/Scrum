using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrum.Models
{
    [Table("Phases")]
    public class Phase
    {
        [Key]
        public int PhaseId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
