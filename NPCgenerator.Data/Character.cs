using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Data
{
    public enum Gender
    {
        male, female
    }
    public class Character
    {
        public int CharacterId { get; set; }
        public int PersonalityId { get; set; }
        public int RaceId { get; set; }
        public int EquipmentId { get; set; }
        public int ProfessionId { get; set; }
        public bool Hostile { get; set; }
        public Gender Sex { get; set; }

        public Personality Personality { get; set; }
        public Race Race { get; set; }
        public Equipment Equipment { get; set; }
        public Profession Profession { get; set; }

    }
}
