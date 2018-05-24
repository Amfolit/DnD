using DnDMaster.BackEnd.Classes;
using DnDMaster.BackEnd.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMaster.BackEnd.GameLogic
{
    public class Character
    {

        public int Int { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Perc { get; set; }
        public int Luck { get; set; }
        public int Chr { get; set; }

        Race racial;
        public Race Racial {
            get
            {
                return racial;
            }
            set
            {
                RacesUtils.SetRace(this, value);
            }
        }

        Class specClass;
        public Class SpecClass
        {
            get
            {
                return specClass;
            }
            set
            {
                Class.SetClass(this, value);
            }
        }

        public int Health { get; set; }

        public List<Trait> TraitList;

        public Character()
        {
            SetBase();
            TraitList = new List<Trait>();
        }

        private void SetBase()
        {
            Int = Dex = Str = Chr = Luck = Perc = 2;
        }
    }
}
