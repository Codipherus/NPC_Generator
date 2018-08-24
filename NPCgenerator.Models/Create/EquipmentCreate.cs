using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Models.Create
{
    public class EquipmentCreate
    {
        [Display(Name ="make new awesome stuff")]
        public string EquipmentName { get; set; }
    }
}
