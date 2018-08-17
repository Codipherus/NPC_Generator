using NPCgenerator.Models.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Models.ListItems
{
    public class CharacterListItem
    {
        public int CharacterId { get; set; }
        public Guid UserId { get; set; }
        public GenderType Gender { get; set; }
        public string Race { get; set; }
        public string Profession { get; set; }
        public string Equipment { get; set; }
        public string Personality { get; set; }
        public bool Hostile { get; set; }
    }
}
