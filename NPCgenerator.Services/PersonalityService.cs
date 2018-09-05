using NPCgenerator.Contracts;
using NPCgenerator.Data;
using NPCgenerator.Models.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Services
{
    public class PersonalityService : IPersonalityService
    {
        private Guid _ownerId;

        public PersonalityService(Guid userId)
        {
            _ownerId = userId;
        }
        public bool CreatePersonality(PersonalityCreate model)
        {
            var entity = new Personality
            {
                OwnerId = _ownerId,
                PersonalityName = model.PersonalityName
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Personalitys.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
