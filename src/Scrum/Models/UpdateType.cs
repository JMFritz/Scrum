using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrum.Models
{
    [Table("UpdateTypes")]
    public class UpdateType
    {
        [Key]
        public int UpdateTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Update> Updates { get; set; }
    }
}
