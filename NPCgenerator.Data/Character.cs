using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Data
{
    public enum GenderType { Male, Female }

    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public GenderType Gender { get; set; }
        [Required]
        public string Race { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string Equipment { get; set; }
        [Required]
        public string Personality { get; set; }
        [Required]
        public bool Hostile { get; set; }
    }
}
