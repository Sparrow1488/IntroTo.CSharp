using PrivateServices.Console.Models;

namespace PrivateServices.Console.Data
{
    internal class BlogsStorage
    {
        public IEnumerable<Blog> Blogs = new Blog[]
        {
            new Blog()
            {
                Id = 1,
                Title = "Special Blog",
                Description = "No.",
                ContactsId = new int[] {
                    1, 2, 3
                }
            }
        };
    }
}
