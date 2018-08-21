using NPCgenerator.Data;
using NPCgenerator.Models.Create;
using NPCgenerator.Models.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Services
{
    public class CharacterService
    {
        public CharacterDetail CreateCharacter()
        {

            Equipment randEquipment;
            Profession randProfession;
            Personality randPersonality;
            Race randRace;
            string gender;
            bool hostile;

            Random rand = new Random();
            using (var ctx = new ApplicationDbContext())
            {
                
                List<Equipment> equipmentList = ctx.Equipments.ToList();
                int equipmentCount = equipmentList.Count;
                randEquipment = equipmentList[rand.Next(0, equipmentCount++)];

                List<Profession> professionList = ctx.Professions.ToList();
                int professionCount = professionList.Count;
                randProfession = professionList[rand.Next(0, professionCount++)];

                List<Personality> personalityList = ctx.Personalitys.ToList();
                int personalityCount = personalityList.Count;
                randPersonality = personalityList[rand.Next(0, personalityCount++)];

                List<Race> raceList = ctx.Races.ToList();
                int raceCount = raceList.Count;
                randRace = raceList[rand.Next(0, raceCount++)];

                
                int hostileToggle = rand.Next(1, 3);
                if (hostileToggle == 1)
                {
                    hostile = true;
                }
                else if (hostileToggle == 2)
                {
                    hostile = false;
                }
                else hostile = false;

                int genderToggle = rand.Next(1, 3);
                switch (genderToggle)
                {
                    case 1:
                        gender = "female";
                        break;
                    case 2:
                        gender = "male";
                        break;
                    default:
                        gender = "female";
                        break;
                }
            }


            return new CharacterDetail
            {
                Personality = randPersonality.PersonalityName,
                Equipment = randEquipment.EquipmentName,
                Profession = randProfession.ProfessionName,
                Race = randRace.RaceName,
                Hostile = hostile,
                Gender = gender
                
                
                //Hostile (bool)
                //Gender (Enum)
            };
        }
    }
}
