using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrum.Models
{
    [Table("Sprints")]
    public class Sprint
    {
        [Key]
        public int SprintId { get; set; }
        public string Name { get; set; }
        public string Goal { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set;}
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public bool InProgress { get; set; }
        public bool Done { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Update> Updates { get; set; }
        public virtual Project Project { get; set; }
    }
}
