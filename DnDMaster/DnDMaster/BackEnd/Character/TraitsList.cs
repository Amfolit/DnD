using System.Collections.Generic;

namespace DnDMaster.BackEnd.GameLogic
{
    public static class TraitsList
    {
        public static List<Trait> Traits = new List<Trait>()
        {
            new Trait(1, "Can talk to animals"),
            new Trait(2, "Very Fat")
        };

    }
    public class Trait
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public Trait(int id, string desc)
        {
            Id = id;
            Desc = desc;
        }
    }
}