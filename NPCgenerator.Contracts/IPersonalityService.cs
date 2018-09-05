using NPCgenerator.Models.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Contracts
{
    public interface IPersonalityService
    {
        bool CreatePersonality(PersonalityCreate model);
    }
}
