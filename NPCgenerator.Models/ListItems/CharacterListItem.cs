using NPCgenerator.Models.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Models.ListItems
{
    public class CharacterListItem
    {
        [Display(Name ="BOY OR GIRL")]
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Profession { get; set; }
        public string Equipment { get; set; }
        public string Personality { get; set; }
        public bool Hostile { get; set; }
    }
}
