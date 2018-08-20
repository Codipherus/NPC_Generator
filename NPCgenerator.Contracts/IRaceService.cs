using NPCgenerator.Models.Create;
using NPCgenerator.Models.Details;
using NPCgenerator.Models.Edit;
using NPCgenerator.Models.ListItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Contracts
{
    public interface IRaceService
    {
        bool CreateRace(RaceCreate model);
        bool UpdateRace(RaceEdit model);
        RaceDetail GetRaceById(int raceId);
        bool DeleteRace(int raceId);
        IEnumerable<RaceListItem> GetRaces();

    }
}
