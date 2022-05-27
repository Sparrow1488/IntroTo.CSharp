using PrivateServices.Console.Data;
using PrivateServices.Console.Models;

namespace PrivateServices.Console.Services
{
    internal abstract class BlogsServiceBase
    {
        public BlogsServiceBase(BlogsStorage storage, CurrentClient currentClient)
        {
            Storage = storage;
            CurrentClient = currentClient;
        }

        public BlogsStorage Storage { get; }
        public CurrentClient CurrentClient { get; }

        public abstract Blog GetById(int id);
        public abstract Blog Edit(Blog blog);
    }
}
