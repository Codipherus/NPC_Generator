using NPCgenerator.Models.ListItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NPCgenerator.Models
{
    public class MixModel
    {
        public string EquipmentName { get; set; }
        public string RaceName { get; set; }
        public ICollection<RaceListItem> Races { get; set; }
        public ICollection<EquipmentListItem> Equipments { get; set; }
        public MixModel(ICollection<RaceListItem> races, ICollection<EquipmentListItem> equipments)
        {
            Races = races;
            Equipments = equipments;
        }
    }
}
