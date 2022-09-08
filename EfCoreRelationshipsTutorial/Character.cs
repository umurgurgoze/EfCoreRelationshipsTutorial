using System.Text.Json.Serialization;

namespace EfCoreRelationshipsTutorial
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string RpgClass { get; set; } = "Knight";
        ////*******************////////////////// ==> User ile 1:1 ilişki . 1 Character 1 User. <==
        [JsonIgnore]
        public User User { get; set; }
        public int UserId { get; set; }
        ////*******************/////////////////
        public Weapon Weapon { get; set; } // => Weapon ile 1:1 ilişki.1 Character 1 Weapon <==
        //public int WeaponId { get; set; }
        //To identify the dependent side of the relationship, configure the foreign key property hatasından dolayı
        //WeaponId sildik.
        
        public List<Skill> Skills { get; set; } // ==> Skill ile N:N ilişki. N Character N Skill <==

    }
}
