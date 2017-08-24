using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Scrum.Models
{
    [Table("UserProjects")]
    public class UserProject
    {
        [Key]
        public int UserProjectId { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public Project Project { get; set; }
        public ApplicationUser User { get; set; }
    }
}
