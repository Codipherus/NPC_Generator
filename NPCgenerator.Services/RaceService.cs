using NPCgenerator.Contracts;
using NPCgenerator.Data;
using NPCgenerator.Models;
using NPCgenerator.Models.Create;
using NPCgenerator.Models.Details;
using NPCgenerator.Models.Edit;
using NPCgenerator.Models.ListItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Services
{
    public class RaceService
    {
        private readonly Guid _userId;
        
        public RaceService(Guid userId)
        {
            _userId = userId;
        }
//CREATE
        public bool CreateRace(RaceCreate model)
        {
            var entity =
                new Race()
                {
                    OwnerId = _userId,
                    
                    RaceName = model.RaceName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Races.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        
//DETAIL
        public RaceDetail GetRaceById(int raceId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Races
                    .Single(e => e.RaceId == raceId && e.OwnerId == _userId);
                return
                    new RaceDetail
                    {
                        RaceId = entity.RaceId,
                        RaceName = entity.RaceName,
                    };
            }
        }

//DELETE
        public bool DeleteRace(int raceId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Races
                        .Single(e => e.RaceId == raceId && e.OwnerId == _userId);
                ctx.Races.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }


//Get List
        public List<string> GetRaceList()
        {
            List<string> races = new List<string>();
            using (var ctx = new ApplicationDbContext())
            {
                foreach (var race in ctx.Races)
                {
                    races.Add(race.RaceName);
                }
            }
            return races;
        }

        public string GetRandomRaceFromList(List<string> raceList)
        {
            Random rand = new Random();
            var raceId = rand.Next(raceList.Count);
            var raceName = raceList[raceId]; 

            return raceName;
        }



        //Joshua's help
        //public bool UpdateRace(RaceEdit model)
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //                .Races
        //                .Single(e => e.RaceId == model.RaceId && e.OwnerId == _userId);
        //        entity.RaceName = model.RaceName;
        //        return ctx.SaveChanges() == 1;
        //    }
        //}


        //public IEnumerable<RaceListItem> GetRaces()
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var query =
        //            ctx
        //                .Races
        //                .Where(e => e.OwnerId == _userId)
        //                .Select(
        //                    e =>
        //                        new RaceListItem
        //                        {
        //                            RaceName = e.RaceName,
        //                        }
        //                );
        //        return query.ToArray();
        //    }

        //}

    }
}
