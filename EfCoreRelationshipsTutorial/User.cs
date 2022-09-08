namespace EfCoreRelationshipsTutorial
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = String.Empty;
        public List<Character> Characters { get; set; } // ==> Character ile 1:n ilişki. 1 User N Character. <==
    }
}
