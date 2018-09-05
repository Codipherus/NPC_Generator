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
    public class RaceService : IRaceService
    {
        private Guid _ownerId;

        public RaceService(Guid userId)
        {
            _ownerId = userId;
        }
        public bool CreateRace(RaceCreate model)
        {
            var entity = new Race
            {
                OwnerId = _ownerId,
                RaceName = model.RaceName
            };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.Races.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
