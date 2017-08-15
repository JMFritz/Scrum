using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrum.Models
{
    [Table("UserStories")]
    public class UserStory
    {
        [Key]
        public int UserStoryId { get; set; }
        public string Spec { get; set; }
    }
}
