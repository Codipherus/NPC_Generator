using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Data
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string RaceName { get; set; }
    }
}
