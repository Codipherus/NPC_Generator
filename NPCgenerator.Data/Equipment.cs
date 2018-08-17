using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Data
{
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        [Required]
        public string EquipmentName { get; set; }
    }
}
