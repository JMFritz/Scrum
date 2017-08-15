using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Scrum.Models
{
    [Table("Projects")]
    public class Project
    { 
        [Key]
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public List<string> UserStories { get; set; }
        public List<Tool> Tools { get; set; }
        public string Description { get; set; }
    }
}
