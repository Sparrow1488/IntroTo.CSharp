namespace PrivateServices.Console.Models
{
    internal class Blog : Identity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<int> ContactsId { get; set; }
    }
}
