using PrivateServices.Console.Data;
using PrivateServices.Console.Models;
using PrivateServices.Console.Roles;

namespace PrivateServices.Console.Services
{
    internal class BlogsService : BlogsServiceBase
    {
        public BlogsService(
            BlogsStorage storage,
            CurrentClient currentClient) : base(storage, currentClient)
        {
        }

        /// <summary>
        ///     Могут редактировать только <see cref="BlogRole.Administrator"/> и <see cref="BlogRole.Moderator"/>
        /// </summary>
        public override Blog Edit(Blog blog)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Могут получать полную информацию только <see cref="SystemRole.User"/> и выше. <see cref="SystemRole.Anon"/>
        ///     могут видеть только название (без id)
        /// </summary>
        public override Blog GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
