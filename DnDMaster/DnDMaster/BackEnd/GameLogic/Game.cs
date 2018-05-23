using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMaster.BackEnd.GameLogic
{
    public class Game
    {

        public List<Character> CharacterList;

        private static Game instance;
        public static Game Instance
        {
            get
            {
                if (instance != null)
                    instance = new Game();
                return instance;
            }
            private set { }
        }

        private Game()
        {
            CharacterList = new List<Character>();
        }

        public void AddCharacter(Character character)
        {
            CharacterList.Add(character);
        }

    }
}
