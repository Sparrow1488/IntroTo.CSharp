namespace PrivateServices.NetCore.Console.Roles
{
    internal class SystemRole
    {
        public const string Admin = nameof(Admin);
        public const string Manager = nameof(Manager);
        public const string User = nameof(User);
        public const string Anon = nameof(Anon);

        public const int AdminRank = 3;
        public const int ManagerRank = 2;
        public const int UserRank = 1;
        public const int AnonRank = 0;

        public static int GetRoleRank(string role)
        {
            if (role == Admin)
                return AdminRank;
            if (role == Manager)
                return ManagerRank;
            if (role == User)
                return UserRank;
            if (role == Anon)
                return AnonRank;
            return -1;
        }
    }
}
