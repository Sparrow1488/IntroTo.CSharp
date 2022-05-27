using PrivateServices.Console.Roles;

namespace PrivateServices.Console.Models
{
    internal class BlogMember
    {
        public int ClientId { get; set; }
        public BlogRole Role { get; set; }
    }
}
