namespace PrivateServices.Console.Roles
{
    internal class BlogRole
    {
        private BlogRole(string role)
        {
            _role = role;
        }

        private readonly string _role;

        public static readonly BlogRole Administrator = new BlogRole(nameof(Administrator));
        public static readonly BlogRole Moderator = new BlogRole(nameof(Moderator));
        public static readonly BlogRole User = new BlogRole(nameof(User));

        public override bool Equals(object? obj)
        {
            if (obj is string stringify)
            {
                return stringify == _role;
            }
            return false;
        }
    }
}
