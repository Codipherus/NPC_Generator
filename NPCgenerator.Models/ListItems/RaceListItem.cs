using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Models.ListItems
{
    public class RaceListItem
    {
        //TODO: annotations...
        [Display(Name="Put something cool here")]
        public string RaceName { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
