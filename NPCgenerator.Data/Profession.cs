using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Data
{
    public class Profession
    {
        [Key]
        public int ProfessionId { get; set; }
        [Required]
        public string ProfessionName { get; set; }
        public Guid OwnerId { get; set; }
    }
}
