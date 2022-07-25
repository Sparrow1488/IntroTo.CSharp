namespace LearnSharp4.DapperSql.Models
{
    internal class Profile
    {
        public Profile(string description, string imageRef)
        {
            Description = description;
            ImageRef = imageRef;
        }

        public int Id { get; private set; } = -1;
        public string Description { get; private set; }
        public string ImageRef { get; private set; }
        public User User { get; set; }

        public int UserId;
    }
}