using NPCgenerator.Data;
using NPCgenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Services
{
    public class CharacterService
    {
        private readonly Guid _userId;

        public CharacterService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateCharacter(CharacterCreate model)
        {
            var entity =
                new Character()
                {
                    UserId = _userId,
                    Race = model.Race,
                    Profession = model.Profession,
                    Equipment = model.Equipment,
                    Personality = model.Personality,
                };
             using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        
    }
}
