using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Data
{
    public class Personality
    {
        [Key]
        public int PersonalityId { get; set; }
        [Required]
        public string PersonalityName { get; set; }
    }
}
