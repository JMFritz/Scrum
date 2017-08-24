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
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public virtual ICollection<UserStory> UserStories { get; set; }
        public virtual ICollection<Update> Updates { get; set; }
        public virtual ICollection<ProjectTool> ProjectTools { get; set; }
        public virtual ICollection<UserProject> UserProjects { get; set; }
        public virtual ICollection<Sprint> Sprints { get; set; }
        public virtual ApplicationUser user { get; set; }
    }
}
