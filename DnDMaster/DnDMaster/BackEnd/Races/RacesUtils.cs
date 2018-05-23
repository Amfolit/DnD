using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMaster.BackEnd.Races
{
    public static class RacesUtils
    {
        public static void SetRace(GameLogic.Character character, Race race)
        {
            character.Racial = race;
            switch (race)
            {
                case Race.Human:
                    character.Chr++;
                    break;
                case Race.Goblin:
                    character.Luck++;
                    break;
                case Race.Orc:
                    character.Health = character.Health + 10;
                    break;
                case Race.BeastFolk:
                    // TODO
                    break;
                case Race.Dwarf:
                    //TODO
                    break;
                default:
                    break;
            }
        }
    }
}
