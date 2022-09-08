using System.Text.Json.Serialization;

namespace EfCoreRelationshipsTutorial
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        [JsonIgnore]
        public List<Character> Characters { get; set; } // ==> Characters ile N:N ilişki. N sayıda skill N sayıda karakterde
        //Önceki .net sürümlerinde CharacterSkills gibi ortak bir sınıf daha açmalıydık. .net5 ve 6da bunu ef otomatik yapıyor.

        //Object cycle hatalarından dolayı bu JsonIgnore'ları ekliyoruz.
    }
}
