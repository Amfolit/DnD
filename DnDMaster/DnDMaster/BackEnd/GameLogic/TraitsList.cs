using System.Collections.Generic;

namespace DnDMaster.BackEnd.GameLogic
{
    public class TraitsList
    {
        public static Dictionary<int, string> Traits = new Dictionary<int, string>()
        {
            {1, "Can Talk to animals" },
            {2, "" }
        };

    }
    public class Trait
    {
        public int Id { get; set; }
    }
}