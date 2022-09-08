using System.Text.Json.Serialization;

namespace EfCoreRelationshipsTutorial
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        /*   1 Weapon 1 Character */
        [JsonIgnore]
        public Character Character { get; set; } // ==> Character ile 1:1 ilişki .1 Character 1 Weapon.
        public int CharacterID { get; set; }
    }
}
