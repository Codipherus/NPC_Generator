using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Models.Create
{
    public enum GenderType { Male, Female }

    public class CharacterCreate
    {
        public string Race { get; set; }
        public string Profession { get; set; }
        public string Equipment { get; set; }
        public string Personality { get; set; }
    }
}
