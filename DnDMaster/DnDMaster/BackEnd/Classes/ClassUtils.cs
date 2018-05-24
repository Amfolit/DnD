using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMaster.BackEnd.Classes
{
    public static class ClassUtils
    {
        public static void SetClass(GameLogic.Character character, Class clas)
        {
            switch (clas)
            {
                case Class.Tank:
                    character.Str = character.Str + 3;
                    character.Luck = character.Luck + 2;
                    character.Dex--;
                    break;
                case Class.Warrior:
                    character.Str = character.Str + 3;
                    character.Perc++;
                    character.Dex++;
                    character.Chr--;
                    break;
                case Class.Mage:
                    character.Int = character.Int + 3;
                    character.Perc = character.Perc + 2;
                    character.Luck++;
                    character.Str--;
                    character.Dex--;
                    break;
                case Class.Rogue:
                    character.Dex = character.Dex + 3;
                    character.Perc++;
                    character.Luck++;
                    character.Chr--;
                    break;
                case Class.Support:
                    character.Perc++;
                    character.Luck++;
                    character.Dex++;
                    character.Int++;
                    character.Chr++;
                    break;
                case Class.Despacito:
                    character.Dex = character.Dex + 2;
                    character.Perc = character.Perc + 2;
                    character.Luck++;
                    character.Str--;
                    break;
                default:
                    break;
            }
        }
    }
}
