using PrivateServices.Console.Roles;

namespace PrivateServices.Console.Services.Arguments
{
    internal class EditClientArgument
    {
        public int Id { get; set; }
        public string EditedName { get; set; } = string.Empty;
    }

    internal class EditClientModeratorArgument : EditClientArgument
    {
        public string EditedRole { get; set; } = SystemRole.Anon;
    }
}
