using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrum.Models
{
    [Table("Tasks")]
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string Description { get; set; }
        public int PhaseId { get; set; }
        public string UserId { get; set; }
        public bool InProgress { get; set; }
        public bool Complete { get; set; }
        public string Priority { get; set; }
        public virtual Phase Phase { get; set; }
        public virtual Sprint Sprint { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
