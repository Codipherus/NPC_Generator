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
    public class ProfessionService : IProfessionService
    {
        private Guid _ownerId;

        public ProfessionService(Guid userId)
        {
            _ownerId = userId;
        }
        public bool CreateProfession(ProfessionCreate model)
        {
            var entity = new Profession
            {
                OwnerId = _ownerId,
                ProfessionName = model.ProfessionName
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Professions.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
