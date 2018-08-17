using NPCgenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Services
{
    public class CharacterService
    {
        public Character CreateCharacter()
        {

            Equipment randEquipment;
            Profession randProfession;
            Personality randPersonality;
            Race randRace;


            Random rand = new Random();
            using (var ctx = new ApplicationDbContext())
            {
                
                List<Equipment> equipmentList = ctx.Equipments.ToList();
                int equipmentCount = equipmentList.Count;
                randEquipment = equipmentList[rand.Next(0, equipmentCount)];

                List<Profession> professionList = ctx.Professions.ToList();
                int professionCount = professionList.Count;
                randProfession = professionList[rand.Next(0, professionCount)];

                List<Personality> personalityList = ctx.Personalitys.ToList();
                int personalityCount = personalityList.Count;
                randPersonality = personalityList[rand.Next(0, personalityCount)];

                List<Race> raceList = ctx.Races.ToList();
                int raceCount = raceList.Count;
                randRace = raceList[rand.Next(0, raceCount)];

                //Hostile (bool)
                //Gender (Enum)
            }


            return new Character
            {
                Personality = randPersonality,
                Equipment = randEquipment,
                Profession = randProfession,
                Race = randRace,

                //Hostile (bool)
                //Gender (Enum)
            };
        }
    }
}
